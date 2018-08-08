using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoftwareInventoryExplorer.Project
{
    public class InventoryProjectManager
    {

        private const int STREAM_COPY_CHUNK_SIZE = 4096;

        private static String serializeProject(InventoryProject project)
        {
            String result = null;
            result = JsonConvert.SerializeObject(project);
            return result;
        }

        private static InventoryProject deserializeProject(String serializedProject)
        {
            return JsonConvert.DeserializeObject<InventoryProject>(serializedProject);
        }

        private static void StreamCopyTo(Stream src, Stream dst)
        {
            byte[] bytes = new byte[STREAM_COPY_CHUNK_SIZE];

            int count;

            while ((count = src.Read(bytes, 0, bytes.Length)) !=0)
            {
                dst.Write(bytes, 0, count);
            }
        }

        private static void writeProjectToCompressedFile(InventoryProject project, String filePath)
        {
            String serializedProject = serializeProject(project);
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(serializedProject);
                MemoryStream inputStream = new MemoryStream(inputBytes);
                using (GZipStream gZipStream = new GZipStream(fileStream, CompressionMode.Compress))
                {
                    StreamCopyTo(inputStream, gZipStream);
                }
                fileStream.Close();
            }
        }

        private static InventoryProject readProjectFromCompressedFile(String filePath)
        {
            InventoryProject result = null;
            String serializedProject = null;
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                MemoryStream outputStream = new MemoryStream();
                using (GZipStream gZipStream = new GZipStream(fileStream, CompressionMode.Decompress))
                {
                    StreamCopyTo(gZipStream, outputStream);
                }
                serializedProject = Encoding.UTF8.GetString(outputStream.ToArray());
            }
            if (serializedProject != null)
            {
                result = deserializeProject(serializedProject);
            }
            return result;
        }

        public static void saveProject(InventoryProject project, String filePath)
        {
            writeProjectToCompressedFile(project, filePath);
        }

        public static InventoryProject openProject(String filePath)
        {
            return readProjectFromCompressedFile(filePath);
        }
    }
}

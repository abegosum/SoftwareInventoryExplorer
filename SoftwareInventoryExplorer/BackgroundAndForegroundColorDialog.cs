using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareInventoryExplorer
{
    public partial class BackgroundAndForegroundColorDialog : Form
    {

        private Color _foregroundColor = SystemColors.ControlText;
        public Nullable<int> ForegroundColor
        {
            get
            {
                return _foregroundColor.ToArgb();
            }
            set
            {
                _foregroundColor = Color.FromArgb(value.Value);
            }
        }

        private Color _backgroundColor = Color.Transparent;
        public Nullable<int> BackgroundColor
        {
            get
            {
                return _backgroundColor.ToArgb();
            }
            set
            {
                _backgroundColor = Color.FromArgb(value.Value);
            }
        }

        public BackgroundAndForegroundColorDialog(Nullable<int> foregroundColorArgb, Nullable<int> backgroundColorArgb)
        {
            InitializeComponent();
            if (foregroundColorArgb != null)
            {
                _foregroundColor = Color.FromArgb(foregroundColorArgb.Value);
            }
            if (backgroundColorArgb != null)
            {
                _backgroundColor = Color.FromArgb(backgroundColorArgb.Value);
            }
        }

        public BackgroundAndForegroundColorDialog(Color foregroundColor, Color backgroundColor)
        {
            InitializeComponent();
            _foregroundColor = foregroundColor;
            _backgroundColor = backgroundColor;
        }

        private void updateSample()
        {
            colorDisplayExampleLabel.BackColor = _backgroundColor;
            colorDisplayExampleLabel.ForeColor = _foregroundColor;
        }

        private DialogResult showColorSelector(Color selectedColor)
        {
            colorSelectDialog.Color = selectedColor;
            return colorSelectDialog.ShowDialog();
        }

        private void BackgroundAndForegroundColorDialog_Load(object sender, EventArgs e)
        {
            updateSample();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void setForegroundColorButton_Click(object sender, EventArgs e)
        {
            if (showColorSelector(_foregroundColor) == DialogResult.OK) 
            {
                _foregroundColor = colorSelectDialog.Color;
                updateSample();
            }
        }

        private void setBackgroundColorButton_Click(object sender, EventArgs e)
        {
            if (showColorSelector(_backgroundColor) == DialogResult.OK)
            {
                _backgroundColor = colorSelectDialog.Color;
                updateSample();
            }
        }
    }
}

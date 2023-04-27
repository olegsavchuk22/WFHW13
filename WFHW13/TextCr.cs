using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHW13
{
    public partial class TextCr : Form
    {
        SolidBrush brush = new SolidBrush(Color.Black);
        Font font = new Font(TextCr.DefaultFont, FontStyle.Regular);
        public string Txt
        {
            get { return textBox1.Text; }
        }
        public SolidBrush Brush { get { return brush; } }
        public Font Fnt { get { return font; } }
        public PointF Point { get { return new PointF((float)numericUpDown1.Value, (float)numericUpDown2.Value); } }

        public TextCr()
        {
            InitializeComponent();
        }

        private void color_btn_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                brush.Color = dlg.Color;
            }
        }
        private void font_btn_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                font = dlg.Font;
            }
        }

        private void set_btn_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

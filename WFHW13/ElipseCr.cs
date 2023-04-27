using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHW13
{
    public partial class ElipseCr : Form
    {
        public RectangleF Rect { get {
                return new RectangleF((float)x_numericUpDown.Value,
                                      (float)y_numericUpDown.Value,
                                      (float)w_numericUpDown.Value,
                                      (float)h_numericUpDown.Value);
            } }
        public Pen Pen_col
        {
            get { return pen; }
        }
        Pen pen = new Pen(Color.Black, 3);
        public ElipseCr()
        {
            InitializeComponent();
        }

        private void set_button_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            }
            else
            {
                MessageBox.Show("Select line type!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void color_button_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pen.Color = dlg.Color;
            }
        }
    }
}

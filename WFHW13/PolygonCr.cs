using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHW13
{
    public partial class PolygonCr : Form
    {
        Pen pen = new Pen(Color.Black, 3);
        public Point[] Points
        {
            get { return new Point[]
            {
                new Point((int)numericUpDown1.Value, (int)numericUpDown2.Value),
                new Point((int)numericUpDown3.Value, (int)numericUpDown4.Value),
                new Point((int)numericUpDown5.Value, (int)numericUpDown6.Value),
            };
            }
        }
        public Pen PenCol
        {
            get { return pen;}
        }
        public PolygonCr()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pen.Color = dlg.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}

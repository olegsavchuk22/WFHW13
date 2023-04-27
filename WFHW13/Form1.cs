using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace WFHW13
{
    public partial class Form1 : Form
    {
        int count = 0;
        List<Figure> figures = new List<Figure>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach(Figure figure in figures)
            {
                figure.Draw(e.Graphics);
            }
            
        }

        private void draw_button_Click(object sender, EventArgs e)
        {
            if (elipse_rbtn.Checked)
            {
                ElipseCr elipse = new ElipseCr();
                elipse.ShowDialog();
                if (elipse.DialogResult == DialogResult.OK)
                {
                    figures.Add(new Figure("Elipse", elipse.Rect, elipse.Pen_col));
                    listBox1.Items.Add(figures[count]);
                    count++;
                }
            }
            if (rect_rbtn.Checked)
            {
                RectangleCr rectangle = new RectangleCr();
                rectangle.ShowDialog();
                if (rectangle.DialogResult == DialogResult.OK)
                {
                    figures.Add(new Figure(rectangle.Rect, "Rectangle", rectangle.Pen_col));
                    listBox1.Items.Add(figures[count]);
                    count++;
                }
            }
            if (pol_rbtn.Checked)
            {
                PolygonCr polygon = new PolygonCr();
                polygon.ShowDialog();
                if (polygon.DialogResult == DialogResult.OK)
                {
                    figures.Add(new Figure("Polygon", polygon.Points, polygon.PenCol));
                    listBox1.Items.Add(figures[count]);
                    count++;
                }
            }
            if (text_rbtn.Checked)
            {
                TextCr text = new TextCr();
                text.ShowDialog();
                if (text.DialogResult == DialogResult.OK)
                {
                    figures.Add(new Figure("String", text.Txt, text.Fnt, text.Brush, text.Point));
                    listBox1.Items.Add(figures[count]);
                    count++;
                }
            }
            if (line_rbtn.Checked)
            {
                LineCr line = new LineCr();
                line.ShowDialog();
                if (line.DialogResult == DialogResult.OK)
                {
                    figures.Add(new Figure(line.Point1, line.Point2, "Line", line.Pen_col));
                    listBox1.Items.Add(figures[count]);
                    count++;
                }
            }
            pictureBox1.Invalidate();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                Figure figure = (Figure)listBox1.SelectedItem;
                switch (figures[listBox1.SelectedIndex].name)
                {
                    case "Elipse":
                        ElipseCr elipse = new ElipseCr();
                        elipse.ShowDialog();
                        if (elipse.DialogResult == DialogResult.OK)
                        {
                            figure.pen = elipse.Pen_col;
                            figure.name = "Elipse";
                            figure.rect_el = elipse.Rect;
                            figures[listBox1.SelectedIndex] = figure;
                        }
                        break;
                    case "Rectangle":
                        RectangleCr rectangle = new RectangleCr();
                        rectangle.ShowDialog();
                        if (rectangle.DialogResult == DialogResult.OK)
                        {
                            figure.pen = rectangle.Pen_col;
                            figure.name = "Rectangle";
                            figure.rect = rectangle.Rect;
                            figures[listBox1.SelectedIndex] = figure;
                        }
                        break;
                    case "Polygon":
                        PolygonCr polygon = new PolygonCr();
                        polygon.ShowDialog();
                        if (polygon.DialogResult == DialogResult.OK)
                        {
                            figure.pen = polygon.PenCol;
                            figure.name = "Polygon";
                            figure.pt_pol = polygon.Points;
                            figures[listBox1.SelectedIndex] = figure;
                        }
                        break;
                    case "String":
                        TextCr text = new TextCr();
                        text.ShowDialog();
                        if (text.DialogResult == DialogResult.OK)
                        {
                            figure.text = text.Txt;
                            figure.name = "String";
                            figure.point = text.Point;
                            figure.brush = text.Brush;
                            figures[listBox1.SelectedIndex] = figure;
                        }
                        break;
                    case "Line":
                        LineCr line = new LineCr();
                        line.ShowDialog();
                        if (line.DialogResult == DialogResult.OK)
                        {
                            figure.pen = line.Pen_col;
                            figure.pen.DashStyle = line.Pen_col.DashStyle;
                            figure.name = "Line";
                            figure.pt_line1 = line.Point1;
                            figures[listBox1.SelectedIndex] = figure;
                        }
                        break;
                    default:
                        break;
                }
                pictureBox1.Refresh();
                pictureBox1.Invalidate();
            }
            catch
            {
                MessageBox.Show("Select figure from the list!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                figures.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                count--;
                pictureBox1.Refresh();
                pictureBox1.Invalidate();
            }
            catch
            {
                MessageBox.Show("Select figure from the list!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

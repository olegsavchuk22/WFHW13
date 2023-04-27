using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHW13
{
    public class Figure
    {
        public string name;
        public string text;

        public RectangleF rect_el;
        public Rectangle rect;

        public Point[] pt_pol;
        public PointF pt_line1;
        public PointF pt_line2;
        public PointF point;

        public Pen pen;
        public SolidBrush brush;
        public Font font;

        public Figure(string name, RectangleF el, Pen pen)
        {
            this.name = name;
            this.rect_el = el;
            this.pen = pen;
            this.pen.DashStyle = pen.DashStyle;
        }
        public Figure(Rectangle rect, string name, Pen pen)
        {
            this.rect = rect;
            this.name = name;
            this.pen = pen;
            this.pen.DashStyle = pen.DashStyle;
        }
        public Figure(string name, string text, Font font, SolidBrush brush, PointF point)
        {
            this.name = name;
            this.text = text;
            this.font = font;
            this.brush = brush;
            this.point = point;
        }
        public Figure(string name, Point[] pt_pol, Pen pen)
        {
            this.name = name;
            this.pt_pol = pt_pol;
            this.pen = pen;
            this.pen.DashStyle = pen.DashStyle;
        }
        public Figure(PointF pt_line1, PointF pt_line2, string name, Pen pen)
        {
            this.pt_line1 = pt_line1;
            this.pt_line2 = pt_line2;
            this.name = name;
            this.pen = pen;
            this.pen.DashStyle = pen.DashStyle;
        }

        public override string ToString()
        {
            return $"{this.name}";
        }
        public void Draw(Graphics g)
        {
            switch (name)
            {
                case "Elipse":
                    g.DrawEllipse(pen, rect_el);
                    break;
                case "Rectangle":
                    g.DrawRectangle(pen, rect);
                    break;
                case "Polygon":
                    g.DrawPolygon(pen, pt_pol);
                    break;
                case "String":
                    g.DrawString(text, font, brush, point);
                    break;
                case "Line":
                    g.DrawLine(pen, pt_line1, pt_line2);
                    break;
                default:
                    break;
            }
        }
    }
}

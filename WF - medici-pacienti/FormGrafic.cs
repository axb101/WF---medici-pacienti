using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF___medici_pacienti
{
    public partial class FormGrafic : Form
    {
        int nrobs;
        float[] x, y;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle zonaClient = e.ClipRectangle;
            Brush fundal = new SolidBrush(Color.White);
            g.FillRectangle(fundal, zonaClient);

            zonaClient.X += 20; zonaClient.Y += 20;
            zonaClient.Height -= 40; zonaClient.Width -= 40;

            int vl = zonaClient.Left, vr = zonaClient.Right;
            int vb = zonaClient.Bottom, vt = zonaClient.Top;

            Pen creionRosu = new Pen(Color.Red, 2);
            g.DrawRectangle(creionRosu, zonaClient);

            SolidBrush[] pensule = new SolidBrush[]
            { new SolidBrush(Color.Pink),
            new SolidBrush(Color.Purple),
            new SolidBrush(Color.LightBlue),
            new SolidBrush(Color.Yellow),
            new SolidBrush(Color.LightGreen),
            new SolidBrush(Color.LightCyan)
            };

            Pen[] creioane = new Pen[]
                { new Pen (Color.Red),
                new Pen (Color.Blue),
                new Pen (Color.Green),
                new Pen (Color.Cyan),
                new Pen (Color.Yellow),
                new Pen (Color.Olive)
                };

            float rap_dist_lat = 0.2f, max;
            int lat, dist;

            SolidBrush pensulaCurenta;
            Pen creionCurent;

            lat = (vr - vl) / (int)((nrobs + 1) * rap_dist_lat + nrobs);

            dist = (int)(lat * rap_dist_lat);

            creionCurent = creioane[0];pensulaCurenta = pensule[5];
            g.DrawLine(creionCurent, vl, vt, vl, vb);
            g.DrawLine(creionCurent, vl, vb, vr, vb);

            int i;
            for (max = y[0], i = 1; i < nrobs; i++)
            {
                if (max < y[i]) max = y[i];
            }
            


            for (i = 0; i < nrobs; i++)
            {
                pensulaCurenta = pensule[(4 + i) % 6];
                PointF pnt = new PointF(vl + dist + i * (lat + dist),
                    vb - y[i] * (vb - vt) / max);
                SizeF sz = new SizeF(lat, y[i] * (vb - vt) / max);
                g.FillRectangle(pensulaCurenta, new RectangleF(pnt, sz));
            }


        }

        public FormGrafic()
        {
            InitializeComponent();

            nrobs = 5;
            x = new float[] { 1980, 1985, 1990, 1995, 2020 };
            y = new float[] { 3200.0f, 96.0f, 78.0f, 56.0f,95.0f };
            // 96=> 500 pixel
            // 32 => 500*32/96 = 167 
        }
    }
}

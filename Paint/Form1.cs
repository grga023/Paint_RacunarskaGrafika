using System.Drawing.Imaging;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 1150;
            this.Height = 850;

            bm = new Bitmap(picColor.Width, picColor.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            picColor .Image = bm;        
        }


        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        int index;
        Pen pen = new Pen(Color.Black, 1);
        Pen gumica = new Pen(Color.White, 4);
        int x, y, sX, sY, cX, cY;
        ColorDialog cd = new ColorDialog();
        Color newColor;

        private void btnOlovka_Click(object sender, EventArgs e)
        {
            index = 1;
        }
        private void btnGumica_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btnElipsa_Click(object sender, EventArgs e)
        {
            index = 3;
        }
        private void btnKvadrat_Click(object sender, EventArgs e)
        {
            index = 4;
        }
        private void btnLinija_Click(object sender, EventArgs e)
        {
            index = 5;
        }       
        private void btnPopuni_Click(object sender, EventArgs e)
        {
            index = 7;
        }
        private void picColor_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }
        private void picColor_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(pen, px, py);
                    py = px;
                }
                else if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(gumica, px, py);
                    py = px;
                }
                picColor.Refresh();

                x = e.X;
                y = e.Y;

                sX = x - cX;
                sY = y - cY;
            }
        }
        private void picColor_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(pen, cX, cY, sX, sY);
                }
                else if (index == 4)
                {
                    g.DrawRectangle(pen, cX, cY, sX, sY);
                }
                else if (index == 5)
                {
                    g.DrawLine(pen, cX, cY, x, y);
                }
            }
        }
        private void btnOcisti_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            picColor.Image = bm;
            index = 0;
        }
        private void picColor_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if(index == 3)
            {
                g.DrawEllipse(pen, cX, cY, sX, sY);
            }
            else if (index == 4)
            {
                g.DrawRectangle(pen, cX, cY, sX, sY);
            }
            else if (index == 5)
            {
                g.DrawLine(pen, cX, cY, x, y);
            }
            picColor.Refresh();
        }
        private void picColor_MouseClick(object sender, MouseEventArgs e)
        {
            if(index == 7)
            {
                Point point = setPoint(picColor, e.Location);
                FillFigure(bm, point.X, point.Y, newColor);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if(saveDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, picColor.Width, picColor.Height), bm.PixelFormat);
                btm.Save(saveDialog.FileName, ImageFormat.Jpeg);
            }
        }
        private void btnBoja_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            newColor = cd.Color;
            OdabirBoje.BackColor = cd.Color;
            pen.Color = cd.Color;
        }
        static Point setPoint(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Width / pb.Width;
            float pY = 1f * pb.Height / pb.Height;

            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = setPoint(OdabirBoje, e.Location);
            izabranaBoja.BackColor = ((Bitmap)OdabirBoje.Image).GetPixel(point.X, point.Y);
            newColor = izabranaBoja.BackColor;
            pen.Color = newColor;
        }
        private void validate(Bitmap bm, Stack<Point>sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if(cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }
        public void FillFigure(Bitmap bm, int x, int y, Color new_color)
        {
            Color old_colr = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_color);   
            if (old_colr == new_color) return;

            while(pixel.Count > 0)
            {
                Point p = (Point)pixel.Pop();
                if(p.X <= p.Y || p.X >= p.Y && p.X < bm.Width && p.Y < bm.Height)
                {
                    validate(bm, pixel, p.X - 1, p.Y, old_colr, new_color);
                    validate(bm, pixel, p.X, p.Y - 1, old_colr, new_color);
                    validate(bm, pixel, p.X + 1, p.Y, old_colr, new_color);
                    validate(bm, pixel, p.X, p.Y + 1, old_colr, new_color);
                }
            } 
        }

    }
}
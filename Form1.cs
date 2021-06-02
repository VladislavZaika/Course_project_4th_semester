using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GDI
{
    
    public partial class Building : Form
    {
    
        int[] g1, g2, p1, p2;
        int cycle = 0;
        int graf_equal1 = 0, graf_equal2 = 0;

        public Building(int[] formG1, int[] formG2, int[] formP1, int[] formP2) 
        {
            InitializeComponent();
            g1 = formG1;
            g2 = formG2;
            p1 = formP1;
            p2 = formP2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
        
            
        }
        

        private void Building_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            
            this.Paint += new PaintEventHandler(Building_Paint);

        }
        private void Building_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
           
                e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, 800, 5));
                e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, 5, 550));
                e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(800, 0, 5, 550));
                e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 545, 800, 5));
                e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(850, 0, 800, 5));
                e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(845, 0, 5, 550));
                e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(1645, 0, 5, 550));
                e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(850, 545, 800, 5));

                
                Paint1(-35, 125, g1, p1, e);
                Paint1(810, 125, g2, p2, e);
        }

        public void Paint1(int x, int y, int[] formG1, int[] formP1, PaintEventArgs e)
        {
            int[] FO = FO_Method(formG1, formP1);

            bool dd = Vertex_connection(formP1.Length, FO).Item1;
            int[] RedMas = Vertex_connection(formP1.Length, FO).Item2;
            int[] BlueMas = Vertex_connection(formP1.Length, FO).Item3;

            

            int ForX = 5;
            Random rnd = new Random();
            String drawString = "";
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            StringFormat drawFormat = new StringFormat();
            int N = 0;
            int d = 0;
            int[] mas = new int[21];
            int[] arr = new int[21];
            for (int i = 0; i < FO.Length; i++)
            {
                if (FO[i] == 0)
                    N++;
            }

            int[,] XY = new int[N, 2];
            for (int i = 0; i < 21; i++)
            {
                mas[i] = 0;
                arr[i] = 0;
            }
            for (int i = 0; i <= 21; i++)
            {
                int u = rnd.Next(1, 21);
                if (mas[u] == 0)
                {
                    mas[u] = 1;

                    arr[i] = u;
                }
                else if (i == 20)
                    i++;
                else
                    i--;
            }
                      
            for (int i = 1; i <= 20; i++)
            {
                if (i == 11)
                {
                    y = 375;
                    x = x - 760;
                }
                else
                {
                    x += 80;
                }
                d = arr[i - 1];

                if (d <= N)
                {
                    XY[d - 1, 0] = x + 17;
                    XY[d - 1, 1] = y + 17;
                }


            }
            
            int vera = 1;
            for (int i = 0; i <= FO.Length - 1; i++)
            {
                if (vera > N)
                    break;
                if (FO[i] == 0)
                    vera++;
                else
                {
                    if ((XY[vera - 1, 1] < 250 && XY[FO[i] - 1, 1] > 250) || (XY[vera - 1, 1] > 250 && XY[FO[i] - 1, 1] < 250) || XY[vera - 1, 0] - XY[FO[i] - 1, 0] == 80 || XY[vera - 1, 0] - XY[FO[i] - 1, 0] == -80)
                        Arrow(XY, e, vera, FO[i]);

                    else
                        UnArrow(XY, e, vera, FO[i]);
                }


            }
            for (int i = 1; i <= 20; i++)
            {
                d = arr[i - 1];

                if (d <= N)
                {
                    if (dd == true)
                    {
                        if(RedMas.Contains(d))
                        {
                            drawString = Convert.ToString(d);
                            e.Graphics.FillEllipse(new SolidBrush(Color.Red), new RectangleF(XY[d - 1, 0] - 17, XY[d - 1, 1] - 17, 35, 35));
                            e.Graphics.DrawString(drawString, drawFont, drawBrush, XY[d - 1, 0] - 17 + ForX, XY[d - 1, 1] - 12);
                        }
                        else
                        {
                            drawString = Convert.ToString(d);
                            e.Graphics.FillEllipse(new SolidBrush(Color.Blue), new Rectangle(XY[d - 1, 0] - 17, XY[d - 1, 1] - 17, 35, 35));
                            e.Graphics.DrawString(drawString, drawFont, drawBrush, XY[d - 1, 0] - 17 + ForX, XY[d - 1, 1] - 12);
                        }
                    }
                    else
                    {
                        drawString = Convert.ToString(d);
                        e.Graphics.FillEllipse(new SolidBrush(Color.LightGray), new Rectangle(XY[d - 1, 0] - 17, XY[d - 1, 1] - 17, 35, 35));
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, XY[d - 1, 0] - 17 + ForX, XY[d - 1, 1] - 12);
                    }
                }


            }
            cycle++;
            if (cycle == 1)
            {
                if (dd == true)
                {
                    textBox_Graf1.Text = "Граф двудолен";
                    graf_equal1 = 1;
                }
                else
                    textBox_Graf1.Text = "Граф не двудолен";
            }
            else
            {
                if (dd == true)
                {
                    textBox_Graf2.Text = "Граф двудолен";
                    graf_equal2 = 1;
                }
                else
                    textBox_Graf2.Text = "Граф не двудолен";
            }
            if (cycle == 2)
                Equal(graf_equal1, graf_equal2);
        }

        public void Equal(int equal1, int equal2)
        {
            if (equal1 == equal2)
                textBox_result.Text = "Графы эквивалентны";
            else
                textBox_result.Text = "Графы не эквивалентны";
        }

        public void Arrow(int[,] YX, PaintEventArgs ev, int eva, int reva)
        {

            int x = 0;
            int y = 0;
            int x1 = 0;
            int y1 = 0;
            if (YX[eva - 1, 0] - YX[reva - 1, 0] == 80)
            {
                x1 = YX[eva - 1, 0] - 17;
                y1 = YX[eva - 1, 1];
                x = YX[reva - 1, 0] + 17;
                y = YX[reva - 1, 1];
            }
            else if (YX[eva - 1, 0] - YX[reva - 1, 0] == -80)
            {
                x1 = YX[eva - 1, 0] + 17;
                y1 = YX[eva - 1, 1];
                x = YX[reva - 1, 0] - 17;
                y = YX[reva - 1, 1];
            }
            else if ((YX[eva - 1, 1] < 250 && YX[reva - 1, 1] > 250))
            {
                x1 = YX[eva - 1, 0];
                y1 = YX[eva - 1, 1];
                y = YX[reva - 1, 1] - 17;
                x = ((YX[reva - 1, 1] - 17 - YX[eva - 1, 1]) * (YX[reva - 1, 0] - YX[eva - 1, 0]) / (YX[reva - 1, 1] - YX[eva - 1, 1]) + YX[eva - 1, 0]);
            }
            else
            {
                x1 = YX[eva - 1, 0];
                y1 = YX[eva - 1, 1];
                y = YX[reva - 1, 1] + 17;
                x = ((YX[reva - 1, 1] + 17 - YX[eva - 1, 1]) * (YX[reva - 1, 0] - YX[eva - 1, 0]) / (YX[reva - 1, 1] - YX[eva - 1, 1]) + YX[eva - 1, 0]);
            }
           
            ev.Graphics.DrawLine(Pens.Black, YX[eva - 1, 0], YX[eva - 1, 1], x, y);
            Pen p = new Pen(Color.Black, 2);
            int pero_x1 = x1, pero_y1 = y1, pero_x2 = x, pero_y2 = y;
            double ugol = Math.Atan2(pero_x1 - pero_x2, pero_y1 - pero_y2);

            ev.Graphics.DrawLine(p, pero_x2, pero_y2, Convert.ToInt32(pero_x2 + 15 * Math.Sin(0.3 + ugol)), Convert.ToInt32(pero_y2 + 15 * Math.Cos(0.3 + ugol)));
            ev.Graphics.DrawLine(p, pero_x2, pero_y2, Convert.ToInt32(pero_x2 + 15 * Math.Sin(ugol - 0.3)), Convert.ToInt32(pero_y2 + 15 * Math.Cos(ugol - 0.3)));
        }
             public void UnArrow(int[,] YX, PaintEventArgs ev, int eva, int reva)
        {
            Pen blackPen = new Pen(Color.Black, 1);
            int t = 0;
            int r = 0;
            int width = 0;
            int height = 0;
            int startAngle = 0;
            int sweepAngle = 180;
            int pero_y1 = YX[reva - 1, 1] + 17;
            int pero_y2 = YX[reva - 1, 1] + 16;
            int pero_x1 = YX[reva - 1, 0], pero_x2 = YX[reva - 1, 0];
            r = YX[reva - 1, 1] - 23;
            if (YX[eva - 1, 1] < 250 && YX[reva - 1, 1] < 250)
            {
                pero_y1 = YX[reva - 1, 1] - 17;
                pero_y2 = YX[reva - 1, 1] - 16;
                startAngle = 180;
                sweepAngle = 180;
                r = YX[reva - 1, 1] - 57;
            }
            if (YX[reva - 1, 0] < YX[eva - 1, 0])
            {
               t = YX[reva - 1, 0];

               width = YX[eva - 1, 0] - YX[reva - 1, 0];
               height = 80;
            }
            else
            {
                t = YX[eva - 1, 0];
                width = -YX[eva - 1, 0] + YX[reva - 1, 0];
                height = 80;
            }
            if (YX[reva - 1, 0] == YX[eva - 1, 0])
            {
                if (YX[reva - 1, 1] < 250)
                    r = YX[reva - 1, 1] - 60;
                else
                    r = YX[reva - 1, 1] - 23;
                t = YX[eva - 1, 0]-17;
                pero_x1 = YX[reva - 1, 0] - 15;
                pero_x2 = YX[reva - 1, 0] - 15;
                width = 35;
                height = 80;
            }
            Pen p = new Pen(Color.Black, 2);

            
            double ugol = Math.Atan2(pero_x1 - pero_x2, pero_y1 - pero_y2);

            ev.Graphics.DrawLine(p, pero_x2, pero_y2, Convert.ToInt32(pero_x2 + 15 * Math.Sin(0.3 + ugol)), Convert.ToInt32(pero_y2 + 15 * Math.Cos(0.3 + ugol)));
            ev.Graphics.DrawLine(p, pero_x2, pero_y2, Convert.ToInt32(pero_x2 + 15 * Math.Sin(ugol - 0.3)), Convert.ToInt32(pero_y2 + 15 * Math.Cos(ugol - 0.3)));
            // Draw arc to screen.
            ev.Graphics.DrawArc(blackPen, t, r, width, height, startAngle, sweepAngle);
            //Получить случайное число (в диапазоне от 0 до 10)
        }

        public (bool, int[], int[]) Vertex_connection(int formP, int[] FO)
        {
            bool graf_dd = true;
            int num = 0;
            int op = 1;
            int[,] var = new int[formP, formP];
            for (int i = 0; i < FO.Length; i++)
            {
                if (FO[i] == 0)
                    num++;
                else
                {
                    for (; op <= formP; op++)
                    {
                        if (FO[i] == op)
                        {
                            var[num, op - 1] = 1;
                            var[op - 1, num] = 1;
                        }
                    }
                }
                op = 1;
            }
            int[] RedMas = new int[formP + 1];
            int[] BlueMas = new int[formP + 1];
            RedMas[1] = 1;
            for (int i = 0; i < formP; i++)
            {
                for (int b = 0; b < formP; b++)
                {
                    if (var[i, b] == 1)
                    {
                        if (RedMas.Contains(i + 1))
                            BlueMas[b + 1] = b + 1;
                        else
                            RedMas[b + 1] = b + 1;
                        for (int m = 0; m < formP; m++)
                        {
                            if (var[b, m] == 1)
                            {
                                if (var[i, m] == 1)
                                    graf_dd = false;
                            }
                        }
                    }
                }
            }
            return (graf_dd, RedMas, BlueMas);
        }

        public int[] FO_Method(int[] formG, int[] formP)
        {
            int[] FO = new int[formG.Length + formP.Length];
            int j = 0, n = 0;
            for (int i = 0; i < formP.Length; i++)
            {
                if (formP[i] == 0)
                {
                    FO[n] = 0;
                    n++;
                }
                else
                {
                    for (; j < formP[i]; j++)
                    {
                        FO[n] = formG[j];
                        n++;
                    }
                    FO[n] = 0;
                    n++;
                }
            }
            return FO;
        }
        
    }
}

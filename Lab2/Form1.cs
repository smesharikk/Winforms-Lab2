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

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            functions.Add(new F_sin());
            functions.Add(new F_x2());
            functions.Add(new F_x3());
            functions.Add(new F_tg());
            functions.Add(new F_2x5());
            groupBox1.Controls.Add(bChooseColor);
            groupBox1.Controls.Add(bRandomFun);
            groupBox1.Controls.Add(bChangeBack);
            groupBox1.Controls.Add(bSave);
            groupBox1.Controls.Add(lFunColor);

        }

        List<IFunction> functions = new List<IFunction>();
        private double k = 1; // коэффициент масштаба
        private int a = 0;// перемещение по оси x
        private int b = 0;// перемещение по оси y
        int one = 50;
        int fun = -1;
        Pen function_pen = new Pen(Color.Black, 2); // ручка графика
        Pen net_pen = new Pen(Color.Gray,1); // ручка сетки
        Pen period_net_pen = new Pen(Color.Gray, 2); // ручка для более жирных линий сетки
        Pen axis_pen = new Pen(Color.Gray, 3); // ручка для осей
        Boolean net = true; // флаг для рисования сетки
        Boolean period_net_exist = true;
        Boolean gradient = false;
        int gradient_color = 1;
        int period_net =5; // с каким периодом нужно рисовать линии сетки более жирными

        private void PanelF_Paint(object sender, PaintEventArgs e)
        {
            int pwight = PanelF.Width; //ширина экрана
            int pheight = PanelF.Height;// высота экрана
            int x0 = pwight / 2 + a; // x координата центра
            int y0 = pheight / 2 + b; // y координата центра

            Graphics g = e.Graphics;

            if (gradient)
            {
                if (gradient_color == 1)
                {
                    LinearGradientBrush linGrBrush = new LinearGradientBrush(
                    new Point(0, 0),
                    new Point(pwight, pheight),
                    Color.Blue,
                    Color.Aqua);
                    g.FillRectangle(linGrBrush, 0, 0, pwight, pheight);
                }
                else
                {
                    LinearGradientBrush linGrBrush = new LinearGradientBrush(
                    new Point(0, 0),
                    new Point(pwight, pheight),
                    Color.Red,
                    Color.Yellow);
                    g.FillRectangle(linGrBrush, 0, 0, pwight, pheight);
                }
            }

            if (net) // рисование сетки при выборе пользователя
            {
                for (int i = 0; i <= pwight / one; i++) 
                {
                    if ((period_net_exist==false)||((i * one + x0 % one - x0) % (one * period_net) != 0))
                        g.DrawLine(net_pen, i * one + x0 % one, 0, i * one + x0 % one, pheight);
                }
                for (int i = 0; i <= pheight / one; i++)
                {
                    if ((period_net_exist == false) || ((i * one + y0 % one - y0) % (one * period_net) != 0))
                        g.DrawLine(net_pen, 0, i * one + y0 % one, pwight, i * one + y0 % one);
                }
            }
            if (period_net_exist) // рисование сетки из более жирных линий на каждом period_net занчении
            {
                for (int i = 0; i<=pwight/one; i++)
                {
                    if ((i * one + x0 % one - x0) % (one * period_net) == 0)
                        g.DrawLine(period_net_pen, i * one + x0 % one, 0, i * one + x0 % one, pheight);
                }
                for (int i = 0; i <= pheight / one; i++)
                {
                    if ((i * one + y0 % one - y0) % (one * period_net) == 0)
                        g.DrawLine(period_net_pen, 0, i * one + y0 % one, pwight, i * one + y0 % one);
                }
            }
            if ((x0>=0)&&(x0<=pwight)) g.DrawLine(axis_pen, x0, 0, x0, pheight); // рисование оси X
            if ((y0>=0)&&(y0<=pheight)) g.DrawLine(axis_pen, 0, y0, pwight, y0);// рисование оси Y
            if (!((y0 + one < 0) || (y0 - one > pheight) || (x0 + one < 0) || (x0 - one > pwight)))//рисование еденичной окружности
            {
                Pen circle_pen = new Pen(axis_pen.Color,axis_pen.Width);
                circle_pen.DashStyle = DashStyle.Dash;
                g.DrawEllipse(circle_pen, x0 - one, y0 - one, 2 * one, 2 * one);
            }
            if (fun != -1)// рисование графика
            {
                for (int i = 0; i < pwight; i++)
                {
                    int y1 = y0 - (int)((functions[fun].calc((double)(i - x0) / one)) * one);
                    int y2 = y0 - (int)((functions[fun].calc((double)(i + 1 - x0) / one)) * one);

                    if (!((y1 < 0) && (y2 < 0) || (y1 > pheight) && (y2 > pheight)))
                    {
                        if ((fun == 3) && ((((y1 - y0) * (y2 - y0) < 0) && (Math.Abs(y1 - y0) + Math.Abs(y2 - y0) > 50))))
                        {
                            g.DrawLine(function_pen, i, y1, i + 1, 0);
                            g.DrawLine(function_pen, i, pheight, i + 1, y2);
                        }
                        else g.DrawLine(function_pen, i, y1, i + 1, y2);
                    }
                }
            }
            if (k != 1)// отображение масштаба
            {
                lScale.Text = "X" + k.ToString();
                lScale.Location = new Point(PanelF.Width - lScale.Size.Width, 0);
            }
            else lScale.Text = "";

            
        }

        //дальше реализуется процесс смещения графика путем нажатия мышкой на график.
        int startx = 0;
        int starty = 0;
        Boolean flag = false;
        private void PanelF_MouseDown(object sender, MouseEventArgs e)
        {
            startx = e.X;
            starty = e.Y;
            PanelF.Focus();
            flag = true;
            PanelF.Invalidate();
        }

        private void PanelF_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {

                a = a - startx+e.X;
                b = b - starty+e.Y;
                startx = e.X;
                starty = e.Y;
                PanelF.Invalidate();
            }
        }
        
        private void PanelF_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void PanelF_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e) // масштабирование
        {

            double k1 = k;
            if (e.Delta > 0) k = Math.Round(k+0.1,1);
            else if (k> 0.1) 
                k = Math.Round(k - 0.1, 1);
            one = (int)Math.Round(one * k / k1);
            a = (int)Math.Round(a * k / k1);
            b = (int)Math.Round(b * k / k1);
            if(k>=0.1) PanelF.Invalidate();
            
        }

        private void bChooseColor_Click(object sender, EventArgs e) // выбор пользователем цвета графика
        {
            ColorDialog FunColor = new ColorDialog();
            FunColor.AllowFullOpen = false;
            FunColor.ShowHelp = true;
            FunColor.Color = lFunColor.BackColor;
            if (FunColor.ShowDialog() == DialogResult.OK)
            {
                lFunColor.BackColor = FunColor.Color;
                function_pen.Color = FunColor.Color;
                PanelF.Invalidate();
            }
        }

        
        private void bRandomFun_Click(object sender, EventArgs e)//Выбор рандомной функциии и ее отображение на экране
        {
            int fun1 = fun;
            while (fun1 == fun)
            {
                Random rnd = new Random();
                fun = rnd.Next(5);
            }
            double k1 = k;
            k = 1;
            one = (int)Math.Round(one * k / k1);
            a = (int)Math.Round(a * k / k1);
            b = (int)Math.Round(b * k / k1);
            PanelF.Invalidate();


        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            PanelF.Invalidate();
        }

        private void bChangeBack_Click(object sender, EventArgs e) //Нажатии кнопки для изменения фона графика
        {
            FormChangeBackPanel ChangeBackPanel = new FormChangeBackPanel(net,(int)net_pen.Width,period_net_exist,period_net,(int)period_net_pen.Width,PanelF.BackColor,net_pen.Color,gradient,gradient_color);
            if (ChangeBackPanel.ShowDialog() == DialogResult.OK)
            {
                net = ChangeBackPanel.get_net();
                net_pen.Color = ChangeBackPanel.get_net_color();
                period_net_pen.Color = ChangeBackPanel.get_net_color();
                axis_pen.Color = ChangeBackPanel.get_net_color();
                net_pen.Width = ChangeBackPanel.get_size_net();
                period_net_exist = ChangeBackPanel.get_period_net_exist();
                period_net = ChangeBackPanel.get_period_net();
                period_net_pen.Width = ChangeBackPanel.get_period_net_size();
                gradient = ChangeBackPanel.get_gradient();
                gradient_color = ChangeBackPanel.get_gradient_color();
                PanelF.BackColor = ChangeBackPanel.get_background_color();
                if ((net == true) && (period_net_exist == true)) axis_pen.Width = Math.Max(net_pen.Width, period_net_pen.Width) + 1;
                else if (net == true) axis_pen.Width = net_pen.Width + 2;
                else if (period_net_exist == true) axis_pen.Width = period_net_pen.Width + 2;
                else axis_pen.Width = 3;
                PanelF.Invalidate();
            }
        }

        private void bSave_Click(object sender, EventArgs e)//Сохранение графика
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Сохранить изображеник графика";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                Bitmap bmp = new Bitmap(PanelF.Width, PanelF.Height);

                PanelF.DrawToBitmap(bmp, new Rectangle(0, 0, PanelF.Width, PanelF.Height));
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        bmp.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        bmp.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        bmp.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }
                fs.Close();
            }

        }

        
    }
}
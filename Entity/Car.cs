using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Entity
{
    public class Car
    {
        public int speed;
        public void DrawRoad(Graphics g)
        {
            Pen p=new Pen(Color.Black,5);
            Pen p0 = new Pen(Color.MistyRose, 5);
            Pen p01 = new Pen(Color.Black, 8);
            Pen p02 = new Pen(Color.Black, 8);




            g.DrawLine(p01, new Point(20, 50), new Point(20, 100));
            // g.FillEllipse(Brushes.Green, 20, 25, 50, 50);//divi1
           // g.FillEllipse(Brushes.MistyRose, 20, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.MistyRose, 0, 40, 15, 10);//1
            g.FillEllipse(Brushes.MistyRose, 20, 40, 15, 10);//3
            g.FillEllipse(Brushes.MistyRose, 10, 30, 15, 10);

            g.DrawLine(p01, new Point(70, 50), new Point(70, 100));
            // g.FillEllipse(Brushes.Green, 20, 25, 50, 50);//divi1
            // g.FillEllipse(Brushes.MistyRose, 20, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.MistyRose, 50, 40, 15, 10);//1
            g.FillEllipse(Brushes.MistyRose, 70, 40, 15, 10);//3
            g.FillEllipse(Brushes.MistyRose, 60, 30, 15, 10);

            g.DrawLine(p01, new Point(120, 50), new Point(120, 100));
            // g.FillEllipse(Brushes.Green, 20, 25, 50, 50);//divi1
            // g.FillEllipse(Brushes.MistyRose, 20, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.MistyRose, 100, 40, 15, 10);//1
            g.FillEllipse(Brushes.MistyRose, 120, 40, 15, 10);//3
            g.FillEllipse(Brushes.MistyRose, 110, 30, 15, 10);

            g.DrawLine(p01, new Point(170, 50), new Point(170, 100));
            // g.FillEllipse(Brushes.Green, 20, 25, 50, 50);//divi1
            // g.FillEllipse(Brushes.MistyRose, 20, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.MistyRose, 150, 40, 15, 10);//1
            g.FillEllipse(Brushes.MistyRose, 170, 40, 15, 10);//3
            g.FillEllipse(Brushes.MistyRose, 160, 30, 15, 10);

            /*g.DrawLine(p01, new Point(300, 50), new Point(170, 100));
             g.FillEllipse(Brushes.Green, 20, 25, 50, 50);//divi1
             g.FillEllipse(Brushes.MistyRose, 20, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.MistyRose, 150, 40, 15, 10);//1
            g.FillEllipse(Brushes.MistyRose, 170, 40, 15, 10);//3
            g.FillEllipse(Brushes.MistyRose, 160, 30, 15, 10);*/


        }
        public void DrawCar(Graphics g, int objId)
        {
            Pen p = new Pen(Color.SaddleBrown, 5);
            Pen p01 = new Pen(Color.Black, 5);
            if (objId == 0)
            {
                g.DrawLine(p01, new Point(40, 100), new Point(40, 60));
                g.DrawLine(p01, new Point(40, 100), new Point(80, 100));
                g.DrawLine(p01, new Point(55, 80), new Point(55, 45));//nicher lomba daag left
                g.DrawLine(p01, new Point(55, 80), new Point(90, 80));//nicher lomba daag left
                g.DrawEllipse(new Pen(Color.Black, 5), 80, 70, 50, 50);
                g.DrawEllipse(new Pen(Color.Black, 5), 90, 80, 30, 30);
               
                g.DrawLine(p01, new Point(40, 60), new Point(55,45));
                g.DrawLine(p01, new Point(55,45), new Point(100,45));
                g.DrawLine(p01, new Point(100,45), new Point(150, 10));//baka daag uporer baam pasher

                //right side portion:
                g.DrawLine(p01, new Point(150, 10), new Point(280, 10));//ekdom uporer lomba daag
                g.DrawLine(p01, new Point(280, 10), new Point(320, 50));//daan pasher baka daag
                g.DrawLine(p01, new Point(320,50), new Point(360,50));
                g.DrawLine(p01, new Point(300, 100), new Point(375, 100));//nicher lomba daag right
                g.DrawLine(p01, new Point(290, 80), new Point(370, 80));//nicher lomba daag right

                g.DrawLine(p01, new Point(360, 50), new Point(370, 80));//nicher daan paser baka daag
                g.DrawLine(p01, new Point(370, 80), new Point(370, 100));

                //right sider er chakar portion:
                g.DrawLine(p01, new Point(130, 100), new Point(250, 100));//nicher lomba daag mid
                g.DrawLine(p01, new Point(120, 80), new Point(260, 80));//nicher lomba daag mid
                g.DrawEllipse(new Pen(Color.Black, 5), 250, 70, 50, 50);
                g.DrawEllipse(new Pen(Color.Black, 5), 260, 80, 30, 30);
                //light
                g.FillRectangle(Brushes.Red, 340, 50, 18, 20);

                //janala
                g.FillRectangle(Brushes.Navy, 187, 20, 50, 20);
                g.FillRectangle(Brushes.Navy, 145, 20, 30, 20);
                g.FillRectangle(Brushes.Navy, 250, 20, 30, 20);
               
            }
            if (objId == 1)
            {
                g.DrawLine(p01, new Point(40, 100), new Point(40, 60));
                g.DrawLine(p01, new Point(40, 100), new Point(80, 100));
                g.DrawLine(p01, new Point(55, 80), new Point(55, 45));//nicher lomba daag left
                g.DrawLine(p01, new Point(55, 80), new Point(90, 80));//nicher lomba daag left
                g.DrawEllipse(new Pen(Color.Black, 5), 80, 70, 50, 50);
                g.DrawEllipse(new Pen(Color.Black, 5), 90, 80, 30, 30);

                g.DrawLine(p01, new Point(40, 60), new Point(55, 45));
                g.DrawLine(p01, new Point(55, 45), new Point(100, 45));
                g.DrawLine(p01, new Point(100, 45), new Point(150, 10));//baka daag uporer baam pasher

                //right side portion:
                g.DrawLine(p01, new Point(150, 10), new Point(280, 10));//ekdom uporer lomba daag
                g.DrawLine(p01, new Point(280, 10), new Point(320, 50));//daan pasher baka daag
                g.DrawLine(p01, new Point(320, 50), new Point(360, 50));
                g.DrawLine(p01, new Point(300, 100), new Point(375, 100));//nicher lomba daag right
                g.DrawLine(p01, new Point(290, 80), new Point(370, 80));//nicher lomba daag right

                g.DrawLine(p01, new Point(360, 50), new Point(370, 80));//nicher daan paser baka daag
                g.DrawLine(p01, new Point(370, 80), new Point(370, 100));
                //light
                g.FillRectangle(Brushes.Red, 55, 45, 18, 20);
                //right sider er chakar portion:
                g.DrawLine(p01, new Point(130, 100), new Point(250, 100));//nicher lomba daag mid
                g.DrawLine(p01, new Point(120, 80), new Point(260, 80));//nicher lomba daag mid
                g.DrawEllipse(new Pen(Color.Black, 5), 250, 70, 50, 50);
                g.DrawEllipse(new Pen(Color.Black, 5), 260, 80, 30, 30);

                //janala
                g.FillRectangle(Brushes.Navy, 187, 20, 50, 20);
                g.FillRectangle(Brushes.Navy, 145, 20, 30, 20);
                g.FillRectangle(Brushes.Navy, 250, 20, 30, 20);
                

            }
            if (objId == 2)
            {
                g.DrawLine(p01, new Point(100,210), new Point(190, 210));
                g.DrawLine(p01, new Point(100, 210), new Point(100, 50));
                g.DrawLine(p01, new Point(100, 50), new Point(120, 20));
                g.DrawLine(p01, new Point(120, 20), new Point(170, 20));
                g.DrawLine(p01, new Point(170, 20), new Point(190, 50));
                g.DrawLine(p01, new Point(190, 210), new Point(190, 50));
                Point[] p1 = { new Point(100, 50), new Point(150, 40), new Point(190, 50) };
                g.DrawCurve(p01, p1);
                g.DrawLine(p01, new Point(100, 50), new Point(130, 70));
                g.DrawLine(p01, new Point(130, 70), new Point(130, 180));
                g.DrawLine(p01, new Point(130, 180), new Point(100, 210));
                g.DrawLine(p01, new Point(190, 50), new Point(160, 70));
                g.DrawLine(p01, new Point(160, 70), new Point(160, 180));
                g.DrawLine(p01, new Point(160, 180), new Point(190, 210));
                g.DrawLine(p01, new Point(130, 70), new Point(160, 70));
                g.DrawLine(p01, new Point(130, 180), new Point(160, 180));

                g.FillRectangle(Brushes.Red, 120, 20, 10, 10);
                g.FillRectangle(Brushes.Red, 160, 20, 10, 10);
               
               
               
               
               
               
      }
            if (objId == 3)
            {
                g.DrawLine(p01, new Point(100, 50), new Point(190, 50));

                Point[] p1 = { new Point(100, 210), new Point(150, 218), new Point(190, 210) };
                g.DrawCurve(p01, p1);
                g.DrawLine(p01, new Point(100, 210), new Point(120, 240));
                g.DrawLine(p01, new Point(120, 240), new Point(170, 240));
                g.DrawLine(p01, new Point(170, 240), new Point(190, 210));


                g.DrawLine(p01, new Point(100, 210), new Point(100, 50));
                g.DrawLine(p01, new Point(190, 210), new Point(190, 50));
                g.DrawLine(p01, new Point(100, 50), new Point(130, 70));
                g.DrawLine(p01, new Point(130, 70), new Point(130, 180));
                g.DrawLine(p01, new Point(130, 180), new Point(100, 210));
                g.DrawLine(p01, new Point(190, 50), new Point(160, 70));
                g.DrawLine(p01, new Point(160, 70), new Point(160, 180));
                g.DrawLine(p01, new Point(160, 180), new Point(190, 210));
                g.DrawLine(p01, new Point(130, 70), new Point(160, 70));
                g.DrawLine(p01, new Point(130, 180), new Point(160, 180));
                g.FillRectangle(Brushes.Red, 120, 230, 10, 10);
                g.FillRectangle(Brushes.Red, 160, 230, 10, 10);
               
           


            }
            
        }
    }
}

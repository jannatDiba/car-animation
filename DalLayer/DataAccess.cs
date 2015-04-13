using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Entity;

namespace DalLayer
{
    public class DataAccess
    {
         public bool saveSpeed(Car c)
        {
            try
            {
                StreamWriter w = new StreamWriter("D:\\APL130225\\CarHomework - Copy\\car.txt");
                w.WriteLine(c.speed);
                w.Close();
                return true;
            }
            catch (Exception)
            {

                return false ;
            }
        }
        public Car getSpeed()
        {
            Car c = new Car();
            try
            {
                StreamReader r = new StreamReader("D:\\APL130225\\CarHomework - Copy\\car.txt");
                c.speed = Convert.ToInt32(r.ReadLine());
                r.Close();
                return c;
            }
            catch (Exception)
            {
                
                return null;
            }
            
        }
    }
    }


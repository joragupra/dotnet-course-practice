using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateExample
{


    class Program
    {
        public delegate void Trigonometric(double value);

        public void writeSin(double value)
        {
            Console.WriteLine("sin{0}:{1}", value, Math.Sin(value));
        }

        public void writeCos(double value)
        {
            Console.WriteLine("cos{0}:{1}", value, Math.Cos(value));
        }
        public void writeTan(double value)
        {
            Console.WriteLine("tan{0}:{1}", value, Math.Tan(value));
        }

        public void run()
        {
            Trigonometric del = new Trigonometric(writeSin);
            del += writeSin;
            del += writeTan;
            del(0.0);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.run();
            Console.ReadKey();
        }
    }
}

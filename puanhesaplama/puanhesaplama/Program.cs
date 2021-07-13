using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puanhesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            double diplomaNotu;
            double obp;
            double hamPuan;
            double ekPuansiz;
            double ekPuanli;

            Console.Write("Lütfen Diploma Notunuzu Giriniz = ");
            diplomaNotu = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("Lütfen Ham Puanınızı Giriniz = ");
            hamPuan = Convert.ToDouble(Console.ReadLine());

            obp = diplomaNotu * 0.6;

            Console.WriteLine("OBP Puanınız = " + obp);

            ekPuansiz = obp + hamPuan;
            ekPuanli = hamPuan + obp + (diplomaNotu * 5 * 0.06);

            Console.WriteLine("Ek Puansız Notunuz = " + ekPuansiz);
            Console.WriteLine("Ek Puanlı Notunuz = " + ekPuanli);

            Console.ReadLine();


        }
    }
}

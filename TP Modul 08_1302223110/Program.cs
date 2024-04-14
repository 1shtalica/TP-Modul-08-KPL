using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Modul_08_1302223110
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CovidConfig config = new CovidConfig().readJSON();

            Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai " + config.satuan_suhu);
            double inputSuhuC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Berapa hari yang lalu anda terakhir memiliki gejala demam?");
            int inputHariC = int.Parse(Console.ReadLine());

            config.CekInputC(inputSuhuC, inputHariC);

            config.UbahSatuan();

            Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai " + config.satuan_suhu);
            double inputSuhuF = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Berapa hari yang lalu anda terakhir memiliki gejala demam?");
            int inputHariF = int.Parse(Console.ReadLine());

            config.CekInputF(inputSuhuF, inputHariF);

            Console.ReadLine();
        }
    }
}

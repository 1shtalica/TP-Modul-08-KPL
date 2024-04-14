using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TP_Modul_08_1302223110
{
    internal class CovidConfig
    {
        public int batas_hari_demam { get; set; }
        public string pesan_diterima { get; set; }
        public string pesan_ditolak { get; set; }
        public string satuan_suhu { get; set; }

        public CovidConfig readJSON()
        {
            String filejson = File.ReadAllText(@"E:\\Programming\\Project\\Kuliah\\KPL\\TP Modul 08\\TP Modul 08_1302223110\\TP Modul 08_1302223110\\covid_config.json");
            CovidConfig covidConfig = JsonConvert.DeserializeObject<CovidConfig>(filejson);
            return covidConfig;
        }

        public void UbahSatuan()
        {
            if (satuan_suhu == "celcius")
            {
                satuan_suhu = "fahrenheit";
            } else
            {
                satuan_suhu = "celcius";
            }
        }

        public void CekInputC(double suhu, int hari)
        {
            if (satuan_suhu == "celcius")
            {
                if (suhu >= 36.5 && suhu <= 37.5 && hari < batas_hari_demam)
                {
                    Console.WriteLine(pesan_diterima);
                }
                else
                {
                    Console.WriteLine(pesan_ditolak);

                }
            }
        }

        public void CekInputF(double suhu, int hari)
        {
            if (satuan_suhu == "fahrenheit")
            {
                if (suhu >= 97.7 && suhu <= 99.5 && hari < batas_hari_demam)
                {
                    Console.WriteLine(pesan_diterima);
                }
                else
                {
                    Console.WriteLine(pesan_ditolak);
                }
            }
        }
    }
}

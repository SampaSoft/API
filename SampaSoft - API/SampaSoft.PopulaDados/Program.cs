using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using SampaSoft.Infraestrutura.EDMX;
using System.Linq;

namespace SampaSoft.PopulaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime StartDate = new DateTime(2018, 6, 1);
            //DateTime EndDate = new DateTime(2018, 6, 16);

            SampasoftDBEntities db = new SampasoftDBEntities();

            //foreach (DateTime dttime in EachDay(StartDate, EndDate))
            //{
            //var txtData = ((dttime.Day < 10 ? "0" + dttime.Day.ToString() : dttime.Day.ToString()) + (dttime.Month < 10 ? "0" + dttime.Month.ToString() : dttime.Month.ToString()) + dttime.Year.ToString());

            //Console.Write("Data: "+ txtData);

            var txtData = "01012018";

            var webRequest = WebRequest.Create("https://www.bec.sp.gov.br/BEC_API/API/convite_encerrado/OC_encerrada/" + txtData) as HttpWebRequest;

            if (webRequest == null)
            {
                return;
            }

            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";

            using (var s = webRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var ocEncerradasAsJson = sr.ReadToEnd();
                    var ocs = JsonConvert.DeserializeObject<IList<OCEncerrada>>(ocEncerradasAsJson);

                    foreach (var xOC in ocs.Distinct())
                    {
                        if (db != null)
                        {
                            Console.WriteLine("OC: " + xOC.OC);

                            try
                            {
                                if (db.OCEncerradas.FirstOrDefault(x => x.OC == xOC.OC) == null)
                                {
                                    db.OCEncerradas.Add(xOC);
                                    db.SaveChanges();
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("ERRO: " + e.ToString());
                                //Console.ReadLine();
                            }
                        }

                    }
                }
            }
        }
        //}

        public static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristAppVersion3.Model
{
    internal class Koncerter
    {
        public Koncerter(string koncertNavn, string tlfNo, string adresse, string tidspunkt, string bands, int pris,
          string billede)
        {
            this.koncertNavn = koncertNavn;
            this.tlfNo = tlfNo;
            this.adresse = adresse;
            this.tidspunkt = tidspunkt;
            this.bands = bands;
            this.pris = pris;
            this.billede = billede;
        }

        public string koncertNavn { get; set; }
        public string tlfNo { get; set; }
        public string adresse { get; set; }
        public string tidspunkt { get; set; }
        public string bands { get; set; }
        public int pris { get; set; }
        public string billede { get; set; }

        public override string ToString()
        {
            //return string.Format("koncertNavn: {0}\n, tlfNo: {1}\n, adresse: {2}\n, tidspunkt: {3}\n, bands: {4}\n, pris: {5}", koncertNavn, tlfNo, adresse, tidspunkt, bands, pris);
            return "";
        }
    }
}

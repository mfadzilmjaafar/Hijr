using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hijr.Models.PesertaHaji
{
    public class Peserta
    {
        public Peserta()
        {
            this.KursusPeserta = new Kursus();
            this.PergerakanPeserta = new Pergerakan();
        }

        public string Nama { get; set; }

        public string KadPengenalan { get; set; }

        public string Alamat1 { get; set; }
        public string Alamat2 { get; set; }

        public string Alamat3 { get; set; }

        public string Poskod { get; set; }
        public string Bandar { get; set; }

        public string Negeri { get; set; }

        public string NoTel { get; set; }

        public string NoAkaun { get; set; }

        public string NoKT { get; set; }

        public string NoKumpulan { get; set; }

        public Kursus KursusPeserta { get; set; }

        public Pergerakan PergerakanPeserta { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hijr.Models
{
    public class HijrViewModel
    {
        List<Kursus> klist;

        public HijrViewModel()
        {
            klist = new List<Kursus>();
        }

        public List<Kursus> KursusList { get; set; }

    }
}
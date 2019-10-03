using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Models
{
    public class vragen
    {
        public int VraagID { get; set; }
        public string Categorie { get; set; }
        public DateTime VraagDatum { get; set; }
        public string GebruikersID { get; set; }
        public string GebruikersNaam { get; set; }
        public int ConsultantID { get; set; }
        public string ConsultantNaam { get; set; }
        public int MyProperty { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Models
{
    public class Article

    {
        public int ID { get; set; }
        public int ConsultantID { get; set; }
        public int CategoryID { get; set; }
        public int Title  { get; set; }
        public DateTime CreationDate  { get; set; }
        public int content  { get; set; }
        public bool IsVisable {get; set; }//bit in database
         
    }
}

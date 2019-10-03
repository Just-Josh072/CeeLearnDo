using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public int CatagoryID { get; set; }
        public char content { get; set; }//var
        public DateTime CreationDate { get; set; }
        public bool ISVisable { get; set; }
        public string Title { get; set; }

            

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManagerSystem.Models
{
    public class Book
    {
        public int ID { get; set; }
        public int Name { get; set; }
        public int Author { get; set; }
        public string Date { get; set; }
    }
}
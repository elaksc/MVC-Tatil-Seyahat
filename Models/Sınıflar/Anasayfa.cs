using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TraversalTrimProject.Models.Sınıflar
{
    public class Anasayfa
    {
        [Key]
        public int Id { get; set; }
        public String Baslik { get; set; }
        public String Aciklama { get; set; }
    }
}
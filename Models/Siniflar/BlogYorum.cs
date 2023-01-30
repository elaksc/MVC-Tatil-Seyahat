using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TraversalTrimProject.Models.Sınıflar;

namespace TraversalTrimProject.Models.Siniflar
{
    //Hangi tablolardan işlem gerçekleştirilecekse
    //o tabloları burayı interface formatında yazmamz gerekiyor
    //Yani IEnumerable format
    public class BlogYorum
    {
        public IEnumerable<Blog> Deger1 { get; set; }
        //bunlar sayesinde bir viewda birden fazal veri çekebileceğiz
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }

    }
}
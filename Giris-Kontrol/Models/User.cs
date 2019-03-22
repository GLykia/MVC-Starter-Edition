using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Giris_Kontrol.Models
{
    public class User
    {
        public Guid ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public string Ad_Soyad { get; set; }
    }
}
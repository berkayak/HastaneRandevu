using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class Doktor
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Nullable<int> PoliklinikID { get; set; }
        public virtual Poliklinik Poliklinik { get; set; }
    }
}

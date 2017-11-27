using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class Randevu
    {
        public int ID { get; set; }
        public Nullable<int> HastaID { get; set; }
        public Nullable<int> HastaneID { get; set; }
        public Nullable<int> PoliklinikID { get; set; }
        public Nullable<System.DateTime> RandevuTarihi { get; set; }
        public Nullable<System.DateTime> OlusturulmaTarihi { get; set; }
        public virtual Kisiler Kisiler { get; set; }
        public virtual Poliklinik Poliklinik { get; set; }
    }
}

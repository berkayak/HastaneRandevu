using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class Kisiler
    {
        public Kisiler()
        {
            this.Randevus = new List<Randevu>();
        }

        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Nullable<decimal> TC { get; set; }
        public string eMail { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public Nullable<byte> Cinsiyet { get; set; }
        public string Parola { get; set; }
        public Nullable<byte> RoleID { get; set; }
        public virtual ICollection<Randevu> Randevus { get; set; }
    }
}

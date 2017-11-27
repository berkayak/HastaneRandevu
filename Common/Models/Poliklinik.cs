using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class Poliklinik
    {
        public Poliklinik()
        {
            this.Doktors = new List<Doktor>();
            this.Randevus = new List<Randevu>();
        }

        public int ID { get; set; }
        public string Adi { get; set; }
        public Nullable<int> HastaneID { get; set; }
        public virtual ICollection<Doktor> Doktors { get; set; }
        public virtual Hastane Hastane { get; set; }
        public virtual ICollection<Randevu> Randevus { get; set; }
    }
}

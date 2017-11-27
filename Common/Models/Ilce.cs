using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class Ilce
    {
        public Ilce()
        {
            this.Hastanes = new List<Hastane>();
        }

        public int ID { get; set; }
        public string Adi { get; set; }
        public Nullable<int> IlID { get; set; }
        public virtual ICollection<Hastane> Hastanes { get; set; }
        public virtual Il Il { get; set; }
    }
}

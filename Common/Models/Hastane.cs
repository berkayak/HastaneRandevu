using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class Hastane
    {
        public Hastane()
        {
            this.Polikliniks = new List<Poliklinik>();
        }

        public int ID { get; set; }
        public string Adi { get; set; }
        public Nullable<int> IlID { get; set; }
        public Nullable<int> IlceID { get; set; }
        public virtual Il Il { get; set; }
        public virtual Ilce Ilce { get; set; }
        public virtual ICollection<Poliklinik> Polikliniks { get; set; }
    }
}

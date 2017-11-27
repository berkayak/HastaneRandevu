using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class Il
    {
        public Il()
        {
            this.Hastanes = new List<Hastane>();
            this.Ilces = new List<Ilce>();
        }

        public int ID { get; set; }
        public string Adi { get; set; }
        public virtual ICollection<Hastane> Hastanes { get; set; }
        public virtual ICollection<Ilce> Ilces { get; set; }
    }
}

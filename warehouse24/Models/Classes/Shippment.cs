using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouse24.Models.Classes
{
    public class Shippment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Tariff { get; set; }
        public float Cost { get; set; }
        public DateTime Time { get; set; }

        public ShippmentCompany Company { get; set; }   
        public Shippment(int id, string name, float tariff, float cost, DateTime time)
        {
            this.Id = id;
            this.Name = name;
            this.Tariff = tariff;
            this.Cost = cost;
            this.Time = time;
        }

        public Shippment() { }  
        public override string ToString() 
        {
            return $"{Id}\t{Name}\t{Tariff}\t{Cost}\t{Time}";

        }


        
    }
}

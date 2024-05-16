using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using warehouse24.Models.Interfaces;

namespace warehouse24.Models.Classes
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public FromWarehouse FromWarehouses { get; set; }
        public ToConsumer ToConsumer { get; set; } 
        public string TypeInvoices { get; set; }
        public Shippment Shipment { get; set; }
        public Goods Goods { get; set; }
        public Invoice() { }

        public Invoice(int id, DateTime date, FromWarehouse  fromWarehouses,ToConsumer toConsumer, string typeInvoices, Shippment shipment, Goods goods) 
        {
            this.Id = id;
            this.DateTime = date;
            this.FromWarehouses = fromWarehouses;
            this.ToConsumer = toConsumer;
            this.TypeInvoices = typeInvoices;
            this.Shipment = shipment;
            this.Goods = goods;
        }

        public override string ToString()
        {
            return $"{Id}\t{DateTime}\t{ToConsumer}\t{TypeInvoices}\t{Shipment}\t{Goods}";

        }
    }
}

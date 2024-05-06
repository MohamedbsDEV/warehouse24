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
        public FromWarehouse FromWarehouse { get; set; }
        public ToWarehouse ToWarehouse { get; set; } 
        public ToConsumer ToConsumer { get; set; } 
        public FromSupplier FromSupplier { get; set; }
        public string TypeInvoices { get; set; }
        public Shippment Shipment { get; set; }

        public Invoice(int id, DateTime date, FromWarehouse  fromWarehouse, ToWarehouse toWarehouse,ToConsumer toConsumer,FromSupplier fromSupplier, string typeInvoices, Shippment shipment) 
        {
            this.Id = id;
            this.DateTime = date;
            this.FromWarehouse = fromWarehouse;
            this.ToWarehouse = toWarehouse;
            this.ToConsumer = toConsumer;
            this.FromSupplier = fromSupplier;
            this.TypeInvoices = typeInvoices;
            this.Shipment = shipment;
            
        }

        public override string ToString()
        {
            return $"{Id}\t{DateTime}\t{FromWarehouse}\t{ToWarehouse}\t{ToWarehouse}\t{ToConsumer}\t{FromSupplier}\t{Shipment}";

        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using warehouse24.Models.Interfaces;

namespace warehouse24.Models.Classes
{
    public class Supplier
    {
        int Id { get; set; }
        string Name { get; set; }
        public Supplier(int id, string name) 
        {
            this.Id = id;
            this.Name = name;
            
        }

        public override string ToString() 
        {
            return $"{Id}   {Name} \n";
        }


    }
}

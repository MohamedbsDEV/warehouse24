﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouse24.Models.Classes
{
    public class ShippmentCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }    

        public ShippmentCompany() { }
        public ShippmentCompany(int id , string name) 
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return $"{Id}  {Name}";
        }
    }
}
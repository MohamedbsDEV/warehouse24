using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouse24.Models.Interfaces;

namespace warehouse24.Models.Classes
{
    public class Consumer : ITo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Consumer(int id , string name)                    
        {
            this.Id = id;
            this.Name = name;
            
        }

        

        public override string ToString()
        {
            return $"{Id}   { Name} \n"; 
        }
    }
}

using System.Drawing;
using System.IO;

namespace warehouse24.Models.Classes
{
    public class Goods
    {
        public  int Id {  get; set; }
        public string  Name {  get; set; }
        public  double Cost {  get; set; }
        public Image Image { get; set; }
    

        public Goods(int id, string name, double cost, Image image)
        {
            Id = id;
            Name = name;
            Cost = cost;
            Image = image;  
          
        }
        public override string ToString() 
        {
            return $"{Id}   {Name}  {Cost} {Image}\n ";
        }
    }
}
using System.Collections.Generic;

namespace MyWay.Models
{
    public class Tour
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }
        public string Counrty { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public Category Category { get; set; }
    }
}

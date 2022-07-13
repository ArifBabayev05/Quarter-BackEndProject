using System;
using DAL.Base;
using DAL.Entity;

namespace DAL.Models
{
    public class Slider : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Context { get; set; }
        public Image Image { get; set; }
        public int ImageId { get; set; } 
    }
}


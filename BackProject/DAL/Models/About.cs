using System;
using DAL.Base;
using DAL.Entity;

namespace DAL.Models
{
    public class About : BaseEntity, IEntity
    {
        public Image Image { get; set; }
        public int ImageId { get; set; }
        public string Title { get; set; }
        public string Context { get; set; }
        public string Quote { get; set; }
    }
}


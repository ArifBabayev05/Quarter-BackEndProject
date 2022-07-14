using System;
using DAL.Entity;

namespace DAL.Models
{
    public class OurService : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TotalNumber { get; set; }

    }
}


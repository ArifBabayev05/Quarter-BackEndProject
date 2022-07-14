using System;
using DAL.Entity;

namespace DAL.Models
{
    public class TotalNumbers: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float TotalNumber { get; set; }

    }
}


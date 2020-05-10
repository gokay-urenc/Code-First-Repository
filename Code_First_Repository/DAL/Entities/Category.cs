using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Repository.DAL.Entities
{
    public class Category : BaseEntity
    {
        [MaxLength(255)] // Max karakter sayısı belirler.
        public string Description { get; set; }
    }
}
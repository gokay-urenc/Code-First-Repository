using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //
using System.ComponentModel.DataAnnotations.Schema; //
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Repository.DAL.Entities
{
    public class BaseEntity
    {
        [Key] // Primary Key Attribute
        [Column(Order = 1)] // Column ile Database'de sütun sırası belirtilebilir.
        public int ID { get; set; }

        [Column(Order = 2)]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        [Column(TypeName = "datetime2")] // Column aynı zamanda sütun tipinide belirleyebilir.
        public DateTime? AddedDate { get; set; }
    }
}
// Bu class ortak özellik olan class'lara miras verecek ve ortak sütunların oluşturulmasına yardımcı olacaktır.
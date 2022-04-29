using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Codefirst.Models
{
    [Table("tblprds")]
    public class Product
    {
        [Key]
        public int PrId { get; set; }
        public string PrName { get; set; }
        public decimal PrPrice { get; set; }    
        public Category Category { get; set; }  

    }
}
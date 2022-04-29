using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Codefirst.Models
{
    [Table("tblctgry")]
    public class Category
    {
        [Key]
        public int CId { get; set; }

        public int CName { get; set; }
    }
}
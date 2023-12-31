﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore.Data.Entities
{
    [Table(name:"Category", Schema = "c")]
    public class Category
    {
        [Column("category_id")]
        public int Id { get; set; }
        [Required]
       // [MaxLength(50)]
        [Column("category_name",TypeName = "nvarchar(100)")]
        public string Name { get; set; }
       
    }
}

﻿using System.ComponentModel.DataAnnotations;

namespace TheNew1.Models
{
    public class CategoryReq
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Req { get; set; }
    }
}

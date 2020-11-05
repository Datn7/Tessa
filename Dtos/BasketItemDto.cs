﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tessa.Dtos
{
    public class BasketItemDto
    {
        [Required]
        public int Id { get; set; }


        [Required]
        public string ProductName { get; set; }


        [Required]
        [Range(0.1,double.MaxValue, ErrorMessage ="ფასი 0-ზე მეტი უნდა იყოს")]
        public decimal Price { get; set; }


        [Required]
        [Range(1,double.MaxValue, ErrorMessage ="რაოდენობა მინიმუმ 1 უნდა იყოს")]
        public int Quantity { get; set; }


        [Required]
        public string PictureUrl { get; set; }


        [Required]
        public string Brand { get; set; }


        [Required]
        public string Type { get; set; }
    }
}

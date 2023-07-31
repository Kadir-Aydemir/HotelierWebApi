﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.DtoLayer.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string? RoomNumber { get; set; }

        public string? RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        [StringLength(100,ErrorMessage ="Bu alan 100 karakterden fazla değer alamaz!")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string? BedCount { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string? BathCount { get; set; }

        public string? WiFi { get; set; }

        public string? Description { get; set; }
    }
}

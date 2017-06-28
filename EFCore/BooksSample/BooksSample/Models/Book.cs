﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BooksSample.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [MaxLength(60)]
        public string Title { get; set; }
        public string Publisher { get; set; }

        [MaxLength(20)]
        public string Isbn { get; set; }

    }
}

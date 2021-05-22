﻿using System;
using System.Collections.Generic;

#nullable disable

namespace UdemyAPI.Models
{
    public partial class Course
    {
        public int CrsId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public int? PaymentMethod { get; set; }
        public int TopId { get; set; }
        public string Languge { get; set; }
        public string Levels { get; set; }
        public string Subtitle { get; set; }

        public virtual Topic Top { get; set; }
    }
}

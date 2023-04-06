using System;
using System.Collections.Generic;

namespace MyDiary.Models
{
    public partial class Content
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Content1 { get; set; } = null!;
    }
}

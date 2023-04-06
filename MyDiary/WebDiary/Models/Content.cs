using System;
using System.Collections.Generic;

namespace WebDiary.Models;

public partial class Content
{
    public int Id { get; set; }

    public string Content1 { get; set; } = null!;

    public DateTime Date { get; set; }

    public bool? IsSecure { get; set; }

    public bool? IsFavorite { get; set; }
}

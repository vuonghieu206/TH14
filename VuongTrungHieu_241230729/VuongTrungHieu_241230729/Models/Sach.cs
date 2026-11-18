using System;
using System.Collections.Generic;

namespace VuongTrungHieu_241230729.Models;

public partial class Sach
{
    public int MaSach { get; set; }

    public int MaTl { get; set; }

    public string TenSach { get; set; } = null!;

    public decimal? Gia { get; set; }

    public string? Anh { get; set; }

    public virtual TheLoai MaTlNavigation { get; set; } = null!;
}

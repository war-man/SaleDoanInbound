﻿using System;
using System.Collections.Generic;

namespace Data.Models_QLTaiKhoan
{
    public partial class Dmchinhanh
    {
        public int Id { get; set; }
        public string Macn { get; set; }
        public string Tencn { get; set; }
        public string Diachi { get; set; }
        public string Thanhpho { get; set; }
        public string Dienthoai { get; set; }
        public string Fax { get; set; }
        public string Masothue { get; set; }
        public bool? Trangthai { get; set; }
    }
}

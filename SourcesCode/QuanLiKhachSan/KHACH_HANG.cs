
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace QuanLiKhachSan
{

using System;
    using System.Collections.Generic;
    
public partial class KHACH_HANG
{

    public KHACH_HANG()
    {

        this.CHI_TIET_PHIEU_THUE = new HashSet<CHI_TIET_PHIEU_THUE>();

    }


    public int MaKhachHang { get; set; }

    public string TenKhachHang { get; set; }

    public string CMND { get; set; }

    public string DiaChi { get; set; }

    public string MaLoaiKhach { get; set; }



    public virtual ICollection<CHI_TIET_PHIEU_THUE> CHI_TIET_PHIEU_THUE { get; set; }

    public virtual LOAI_KHACH_HANG LOAI_KHACH_HANG { get; set; }

}

}

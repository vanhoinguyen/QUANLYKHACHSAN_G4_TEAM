//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHONG
    {
        public PHONG()
        {
            this.CHI_TIET_HOA_DON = new HashSet<CHI_TIET_HOA_DON>();
            this.PHIEU_THUE_PHONG = new HashSet<PHIEU_THUE_PHONG>();
        }
    
        public int MaPhong { get; set; }
        public string TinhTrang { get; set; }
        public string MaLoaiPhong { get; set; }
        public string GhiChu { get; set; }
    
        public virtual ICollection<CHI_TIET_HOA_DON> CHI_TIET_HOA_DON { get; set; }
        public virtual LOAI_PHONG LOAI_PHONG { get; set; }
        public virtual ICollection<PHIEU_THUE_PHONG> PHIEU_THUE_PHONG { get; set; }
    }
}

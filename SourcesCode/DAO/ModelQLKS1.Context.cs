﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class QUAN_LY_KHACH_SANEntities : DbContext
    {
        public QUAN_LY_KHACH_SANEntities()
            : base("name=QUAN_LY_KHACH_SANEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BAOCAO_DOANHTHUTHEOLOAIPHONG> BAOCAO_DOANHTHUTHEOLOAIPHONG { get; set; }
        public DbSet<BAOCAO_MATDOSUDUNGPHONG> BAOCAO_MATDOSUDUNGPHONG { get; set; }
        public DbSet<CHI_TIET_HOA_DON> CHI_TIET_HOA_DON { get; set; }
        public DbSet<CHI_TIET_PHIEU_THUE> CHI_TIET_PHIEU_THUE { get; set; }
        public DbSet<CHITIET_BAOCAODOANHTHU> CHITIET_BAOCAODOANHTHU { get; set; }
        public DbSet<CHITIET_BAOCAOMATDOSUDUNG> CHITIET_BAOCAOMATDOSUDUNG { get; set; }
        public DbSet<DICH_VU> DICH_VU { get; set; }
        public DbSet<HOA_DON> HOA_DON { get; set; }
        public DbSet<KHACH_HANG> KHACH_HANG { get; set; }
        public DbSet<LOAI_KHACH_HANG> LOAI_KHACH_HANG { get; set; }
        public DbSet<LOAI_PHONG> LOAI_PHONG { get; set; }
        public DbSet<NGUOI_DUNG> NGUOI_DUNG { get; set; }
        public DbSet<PHIEU_THUE_PHONG> PHIEU_THUE_PHONG { get; set; }
        public DbSet<PHONG> PHONGs { get; set; }
        public DbSet<THAM_SO> THAM_SO { get; set; }
        public DbSet<DANG_KI_DICH_VU> DANG_KI_DICH_VU { get; set; }
    
        public virtual int spCapNhatTinhTrangPhong(Nullable<int> maPhong)
        {
            var maPhongParameter = maPhong.HasValue ?
                new ObjectParameter("MaPhong", maPhong) :
                new ObjectParameter("MaPhong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCapNhatTinhTrangPhong", maPhongParameter);
        }
    
        public virtual int spCapNhatTSHeSo(Nullable<double> heSo)
        {
            var heSoParameter = heSo.HasValue ?
                new ObjectParameter("HeSo", heSo) :
                new ObjectParameter("HeSo", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCapNhatTSHeSo", heSoParameter);
        }
    
        public virtual int spCapNhatTSPhuThu(Nullable<double> phuThu)
        {
            var phuThuParameter = phuThu.HasValue ?
                new ObjectParameter("PhuThu", phuThu) :
                new ObjectParameter("PhuThu", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCapNhatTSPhuThu", phuThuParameter);
        }
    
        public virtual int spCapNhatTSSoKhachToiDa(Nullable<int> soKhachToiDa)
        {
            var soKhachToiDaParameter = soKhachToiDa.HasValue ?
                new ObjectParameter("SoKhachToiDa", soKhachToiDa) :
                new ObjectParameter("SoKhachToiDa", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCapNhatTSSoKhachToiDa", soKhachToiDaParameter);
        }
    
        public virtual ObjectResult<spDoanhThuTheoLoaiPhong_Result> spDoanhThuTheoLoaiPhong()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spDoanhThuTheoLoaiPhong_Result>("spDoanhThuTheoLoaiPhong");
        }
    
        public virtual ObjectResult<spDoanhThuTheoLoaiPhongTheoThang_Result> spDoanhThuTheoLoaiPhongTheoThang(Nullable<int> thang, Nullable<int> nam)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("Thang", thang) :
                new ObjectParameter("Thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("Nam", nam) :
                new ObjectParameter("Nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spDoanhThuTheoLoaiPhongTheoThang_Result>("spDoanhThuTheoLoaiPhongTheoThang", thangParameter, namParameter);
        }
    
        public virtual int spSuaThongTinPhong(Nullable<int> maPhong, string tinhTrang, string maLoaiPhong, string ghiChu)
        {
            var maPhongParameter = maPhong.HasValue ?
                new ObjectParameter("MaPhong", maPhong) :
                new ObjectParameter("MaPhong", typeof(int));
    
            var tinhTrangParameter = tinhTrang != null ?
                new ObjectParameter("TinhTrang", tinhTrang) :
                new ObjectParameter("TinhTrang", typeof(string));
    
            var maLoaiPhongParameter = maLoaiPhong != null ?
                new ObjectParameter("MaLoaiPhong", maLoaiPhong) :
                new ObjectParameter("MaLoaiPhong", typeof(string));
    
            var ghiChuParameter = ghiChu != null ?
                new ObjectParameter("GhiChu", ghiChu) :
                new ObjectParameter("GhiChu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSuaThongTinPhong", maPhongParameter, tinhTrangParameter, maLoaiPhongParameter, ghiChuParameter);
        }
    
        public virtual int spSuaTTLoaiPhong(string maLP, string tenLP, Nullable<decimal> donGia)
        {
            var maLPParameter = maLP != null ?
                new ObjectParameter("MaLP", maLP) :
                new ObjectParameter("MaLP", typeof(string));
    
            var tenLPParameter = tenLP != null ?
                new ObjectParameter("TenLP", tenLP) :
                new ObjectParameter("TenLP", typeof(string));
    
            var donGiaParameter = donGia.HasValue ?
                new ObjectParameter("DonGia", donGia) :
                new ObjectParameter("DonGia", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSuaTTLoaiPhong", maLPParameter, tenLPParameter, donGiaParameter);
        }
    
        public virtual int spThemBCCTDTTheoLoaiPhongTheoThang(Nullable<int> maBCCTDoanhThu, string maLoaiPhong, Nullable<int> maBCDoanhThu, Nullable<decimal> doanhThuThang, string tiLe)
        {
            var maBCCTDoanhThuParameter = maBCCTDoanhThu.HasValue ?
                new ObjectParameter("MaBCCTDoanhThu", maBCCTDoanhThu) :
                new ObjectParameter("MaBCCTDoanhThu", typeof(int));
    
            var maLoaiPhongParameter = maLoaiPhong != null ?
                new ObjectParameter("MaLoaiPhong", maLoaiPhong) :
                new ObjectParameter("MaLoaiPhong", typeof(string));
    
            var maBCDoanhThuParameter = maBCDoanhThu.HasValue ?
                new ObjectParameter("MaBCDoanhThu", maBCDoanhThu) :
                new ObjectParameter("MaBCDoanhThu", typeof(int));
    
            var doanhThuThangParameter = doanhThuThang.HasValue ?
                new ObjectParameter("DoanhThuThang", doanhThuThang) :
                new ObjectParameter("DoanhThuThang", typeof(decimal));
    
            var tiLeParameter = tiLe != null ?
                new ObjectParameter("TiLe", tiLe) :
                new ObjectParameter("TiLe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThemBCCTDTTheoLoaiPhongTheoThang", maBCCTDoanhThuParameter, maLoaiPhongParameter, maBCDoanhThuParameter, doanhThuThangParameter, tiLeParameter);
        }
    
        public virtual int spThemBCCTMDTheoPhongTheoThang(Nullable<int> maBCCTMatDo, string maPhong, Nullable<int> maBCMatDo, Nullable<int> soNgayThue, string tiLe)
        {
            var maBCCTMatDoParameter = maBCCTMatDo.HasValue ?
                new ObjectParameter("MaBCCTMatDo", maBCCTMatDo) :
                new ObjectParameter("MaBCCTMatDo", typeof(int));
    
            var maPhongParameter = maPhong != null ?
                new ObjectParameter("MaPhong", maPhong) :
                new ObjectParameter("MaPhong", typeof(string));
    
            var maBCMatDoParameter = maBCMatDo.HasValue ?
                new ObjectParameter("MaBCMatDo", maBCMatDo) :
                new ObjectParameter("MaBCMatDo", typeof(int));
    
            var soNgayThueParameter = soNgayThue.HasValue ?
                new ObjectParameter("SoNgayThue", soNgayThue) :
                new ObjectParameter("SoNgayThue", typeof(int));
    
            var tiLeParameter = tiLe != null ?
                new ObjectParameter("TiLe", tiLe) :
                new ObjectParameter("TiLe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThemBCCTMDTheoPhongTheoThang", maBCCTMatDoParameter, maPhongParameter, maBCMatDoParameter, soNgayThueParameter, tiLeParameter);
        }
    
        public virtual int spThemBCDoanhThuTheoLoaiPhongTheoThang(Nullable<int> maBCDoanhThu, Nullable<int> thang)
        {
            var maBCDoanhThuParameter = maBCDoanhThu.HasValue ?
                new ObjectParameter("MaBCDoanhThu", maBCDoanhThu) :
                new ObjectParameter("MaBCDoanhThu", typeof(int));
    
            var thangParameter = thang.HasValue ?
                new ObjectParameter("Thang", thang) :
                new ObjectParameter("Thang", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThemBCDoanhThuTheoLoaiPhongTheoThang", maBCDoanhThuParameter, thangParameter);
        }
    
        public virtual int spThemBCMatDoSuDungPhongTheoThang(Nullable<int> maBCCTMatDo, Nullable<int> thang)
        {
            var maBCCTMatDoParameter = maBCCTMatDo.HasValue ?
                new ObjectParameter("MaBCCTMatDo", maBCCTMatDo) :
                new ObjectParameter("MaBCCTMatDo", typeof(int));
    
            var thangParameter = thang.HasValue ?
                new ObjectParameter("Thang", thang) :
                new ObjectParameter("Thang", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThemBCMatDoSuDungPhongTheoThang", maBCCTMatDoParameter, thangParameter);
        }
    
        public virtual int spThemChiTietHD(Nullable<int> maHoaDon, Nullable<int> soNgayThue, Nullable<decimal> donGia, Nullable<decimal> thanhTien, Nullable<System.DateTime> ngayThanhToan, Nullable<int> maPhong)
        {
            var maHoaDonParameter = maHoaDon.HasValue ?
                new ObjectParameter("MaHoaDon", maHoaDon) :
                new ObjectParameter("MaHoaDon", typeof(int));
    
            var soNgayThueParameter = soNgayThue.HasValue ?
                new ObjectParameter("SoNgayThue", soNgayThue) :
                new ObjectParameter("SoNgayThue", typeof(int));
    
            var donGiaParameter = donGia.HasValue ?
                new ObjectParameter("DonGia", donGia) :
                new ObjectParameter("DonGia", typeof(decimal));
    
            var thanhTienParameter = thanhTien.HasValue ?
                new ObjectParameter("ThanhTien", thanhTien) :
                new ObjectParameter("ThanhTien", typeof(decimal));
    
            var ngayThanhToanParameter = ngayThanhToan.HasValue ?
                new ObjectParameter("NgayThanhToan", ngayThanhToan) :
                new ObjectParameter("NgayThanhToan", typeof(System.DateTime));
    
            var maPhongParameter = maPhong.HasValue ?
                new ObjectParameter("MaPhong", maPhong) :
                new ObjectParameter("MaPhong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThemChiTietHD", maHoaDonParameter, soNgayThueParameter, donGiaParameter, thanhTienParameter, ngayThanhToanParameter, maPhongParameter);
        }
    
        public virtual int spThemCTPhieuThue(Nullable<int> maCTPT, Nullable<int> maKH, Nullable<int> maPT)
        {
            var maCTPTParameter = maCTPT.HasValue ?
                new ObjectParameter("MaCTPT", maCTPT) :
                new ObjectParameter("MaCTPT", typeof(int));
    
            var maKHParameter = maKH.HasValue ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(int));
    
            var maPTParameter = maPT.HasValue ?
                new ObjectParameter("MaPT", maPT) :
                new ObjectParameter("MaPT", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThemCTPhieuThue", maCTPTParameter, maKHParameter, maPTParameter);
        }
    
        public virtual int spThemHoaDon(Nullable<int> maHoaDon, string tenKhachHang, Nullable<decimal> triGia)
        {
            var maHoaDonParameter = maHoaDon.HasValue ?
                new ObjectParameter("MaHoaDon", maHoaDon) :
                new ObjectParameter("MaHoaDon", typeof(int));
    
            var tenKhachHangParameter = tenKhachHang != null ?
                new ObjectParameter("TenKhachHang", tenKhachHang) :
                new ObjectParameter("TenKhachHang", typeof(string));
    
            var triGiaParameter = triGia.HasValue ?
                new ObjectParameter("TriGia", triGia) :
                new ObjectParameter("TriGia", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThemHoaDon", maHoaDonParameter, tenKhachHangParameter, triGiaParameter);
        }
    
        public virtual int spThemKhachHang(Nullable<int> maKH, string tenKH, string cMND, string diaChi, string maLK)
        {
            var maKHParameter = maKH.HasValue ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(int));
    
            var tenKHParameter = tenKH != null ?
                new ObjectParameter("TenKH", tenKH) :
                new ObjectParameter("TenKH", typeof(string));
    
            var cMNDParameter = cMND != null ?
                new ObjectParameter("CMND", cMND) :
                new ObjectParameter("CMND", typeof(string));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("DiaChi", diaChi) :
                new ObjectParameter("DiaChi", typeof(string));
    
            var maLKParameter = maLK != null ?
                new ObjectParameter("MaLK", maLK) :
                new ObjectParameter("MaLK", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThemKhachHang", maKHParameter, tenKHParameter, cMNDParameter, diaChiParameter, maLKParameter);
        }
    
        public virtual int spThemLoaiPhong(string maLP, string tenLP, Nullable<decimal> donGia)
        {
            var maLPParameter = maLP != null ?
                new ObjectParameter("MaLP", maLP) :
                new ObjectParameter("MaLP", typeof(string));
    
            var tenLPParameter = tenLP != null ?
                new ObjectParameter("TenLP", tenLP) :
                new ObjectParameter("TenLP", typeof(string));
    
            var donGiaParameter = donGia.HasValue ?
                new ObjectParameter("DonGia", donGia) :
                new ObjectParameter("DonGia", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThemLoaiPhong", maLPParameter, tenLPParameter, donGiaParameter);
        }
    
        public virtual int spThemPhieuThue(Nullable<int> maPT, Nullable<System.DateTime> ngayThue, Nullable<int> maPhong, Nullable<System.DateTime> ngayTraPhong)
        {
            var maPTParameter = maPT.HasValue ?
                new ObjectParameter("MaPT", maPT) :
                new ObjectParameter("MaPT", typeof(int));
    
            var ngayThueParameter = ngayThue.HasValue ?
                new ObjectParameter("NgayThue", ngayThue) :
                new ObjectParameter("NgayThue", typeof(System.DateTime));
    
            var maPhongParameter = maPhong.HasValue ?
                new ObjectParameter("MaPhong", maPhong) :
                new ObjectParameter("MaPhong", typeof(int));
    
            var ngayTraPhongParameter = ngayTraPhong.HasValue ?
                new ObjectParameter("NgayTraPhong", ngayTraPhong) :
                new ObjectParameter("NgayTraPhong", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThemPhieuThue", maPTParameter, ngayThueParameter, maPhongParameter, ngayTraPhongParameter);
        }
    
        public virtual int spThemPhong(string tinhTrang, string maLoaiPhong, string ghiChu)
        {
            var tinhTrangParameter = tinhTrang != null ?
                new ObjectParameter("TinhTrang", tinhTrang) :
                new ObjectParameter("TinhTrang", typeof(string));
    
            var maLoaiPhongParameter = maLoaiPhong != null ?
                new ObjectParameter("MaLoaiPhong", maLoaiPhong) :
                new ObjectParameter("MaLoaiPhong", typeof(string));
    
            var ghiChuParameter = ghiChu != null ?
                new ObjectParameter("GhiChu", ghiChu) :
                new ObjectParameter("GhiChu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThemPhong", tinhTrangParameter, maLoaiPhongParameter, ghiChuParameter);
        }
    
        public virtual int spThietLapTTrangPhongBanDau(Nullable<int> maPhong)
        {
            var maPhongParameter = maPhong.HasValue ?
                new ObjectParameter("MaPhong", maPhong) :
                new ObjectParameter("MaPhong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThietLapTTrangPhongBanDau", maPhongParameter);
        }
    
        public virtual int spTruNgayThangNam(Nullable<System.DateTime> ngayBDThue)
        {
            var ngayBDThueParameter = ngayBDThue.HasValue ?
                new ObjectParameter("NgayBDThue", ngayBDThue) :
                new ObjectParameter("NgayBDThue", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spTruNgayThangNam", ngayBDThueParameter);
        }
    
        public virtual int spXoaCTPhieuThue(Nullable<int> maPhieuThue)
        {
            var maPhieuThueParameter = maPhieuThue.HasValue ?
                new ObjectParameter("MaPhieuThue", maPhieuThue) :
                new ObjectParameter("MaPhieuThue", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spXoaCTPhieuThue", maPhieuThueParameter);
        }
    
        public virtual int spXoaKhachHang(Nullable<int> maKhacHang)
        {
            var maKhacHangParameter = maKhacHang.HasValue ?
                new ObjectParameter("MaKhacHang", maKhacHang) :
                new ObjectParameter("MaKhacHang", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spXoaKhachHang", maKhacHangParameter);
        }
    
        public virtual int spXoaLoaiPhong(string maLP)
        {
            var maLPParameter = maLP != null ?
                new ObjectParameter("MaLP", maLP) :
                new ObjectParameter("MaLP", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spXoaLoaiPhong", maLPParameter);
        }
    
        public virtual int spXoaPhieuThue(Nullable<int> maPhieuThue)
        {
            var maPhieuThueParameter = maPhieuThue.HasValue ?
                new ObjectParameter("MaPhieuThue", maPhieuThue) :
                new ObjectParameter("MaPhieuThue", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spXoaPhieuThue", maPhieuThueParameter);
        }
    
        public virtual int spXoaPhong(Nullable<int> maPhong)
        {
            var maPhongParameter = maPhong.HasValue ?
                new ObjectParameter("MaPhong", maPhong) :
                new ObjectParameter("MaPhong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spXoaPhong", maPhongParameter);
        }
    
        public virtual int spSuaThongTinDichVu(Nullable<int> maDichVu, string tenDichVu, string donViTinh, Nullable<decimal> donGia)
        {
            var maDichVuParameter = maDichVu.HasValue ?
                new ObjectParameter("MaDichVu", maDichVu) :
                new ObjectParameter("MaDichVu", typeof(int));
    
            var tenDichVuParameter = tenDichVu != null ?
                new ObjectParameter("TenDichVu", tenDichVu) :
                new ObjectParameter("TenDichVu", typeof(string));
    
            var donViTinhParameter = donViTinh != null ?
                new ObjectParameter("DonViTinh", donViTinh) :
                new ObjectParameter("DonViTinh", typeof(string));
    
            var donGiaParameter = donGia.HasValue ?
                new ObjectParameter("DonGia", donGia) :
                new ObjectParameter("DonGia", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSuaThongTinDichVu", maDichVuParameter, tenDichVuParameter, donViTinhParameter, donGiaParameter);
        }
    
        public virtual int spThemDichVu(string tenDichVu, string donViTinh, Nullable<decimal> donGia)
        {
            var tenDichVuParameter = tenDichVu != null ?
                new ObjectParameter("TenDichVu", tenDichVu) :
                new ObjectParameter("TenDichVu", typeof(string));
    
            var donViTinhParameter = donViTinh != null ?
                new ObjectParameter("DonViTinh", donViTinh) :
                new ObjectParameter("DonViTinh", typeof(string));
    
            var donGiaParameter = donGia.HasValue ?
                new ObjectParameter("DonGia", donGia) :
                new ObjectParameter("DonGia", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThemDichVu", tenDichVuParameter, donViTinhParameter, donGiaParameter);
        }
    
        public virtual int spXoaDichVu(Nullable<int> maDichVu)
        {
            var maDichVuParameter = maDichVu.HasValue ?
                new ObjectParameter("MaDichVu", maDichVu) :
                new ObjectParameter("MaDichVu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spXoaDichVu", maDichVuParameter);
        }
    
        public virtual int spThemPhong1(string tinhTrang, string maLoaiPhong, string ghiChu)
        {
            var tinhTrangParameter = tinhTrang != null ?
                new ObjectParameter("TinhTrang", tinhTrang) :
                new ObjectParameter("TinhTrang", typeof(string));
    
            var maLoaiPhongParameter = maLoaiPhong != null ?
                new ObjectParameter("MaLoaiPhong", maLoaiPhong) :
                new ObjectParameter("MaLoaiPhong", typeof(string));
    
            var ghiChuParameter = ghiChu != null ?
                new ObjectParameter("GhiChu", ghiChu) :
                new ObjectParameter("GhiChu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThemPhong1", tinhTrangParameter, maLoaiPhongParameter, ghiChuParameter);
        }
    
        public virtual int spThemPhong2(string tinhTrang, string maLoaiPhong, string ghiChu)
        {
            var tinhTrangParameter = tinhTrang != null ?
                new ObjectParameter("TinhTrang", tinhTrang) :
                new ObjectParameter("TinhTrang", typeof(string));
    
            var maLoaiPhongParameter = maLoaiPhong != null ?
                new ObjectParameter("MaLoaiPhong", maLoaiPhong) :
                new ObjectParameter("MaLoaiPhong", typeof(string));
    
            var ghiChuParameter = ghiChu != null ?
                new ObjectParameter("GhiChu", ghiChu) :
                new ObjectParameter("GhiChu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThemPhong2", tinhTrangParameter, maLoaiPhongParameter, ghiChuParameter);
        }
    
        public virtual int spDangKiDichVu(Nullable<int> maDichVu, Nullable<int> maPhong, Nullable<int> soLuong)
        {
            var maDichVuParameter = maDichVu.HasValue ?
                new ObjectParameter("MaDichVu", maDichVu) :
                new ObjectParameter("MaDichVu", typeof(int));
    
            var maPhongParameter = maPhong.HasValue ?
                new ObjectParameter("MaPhong", maPhong) :
                new ObjectParameter("MaPhong", typeof(int));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("SoLuong", soLuong) :
                new ObjectParameter("SoLuong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDangKiDichVu", maDichVuParameter, maPhongParameter, soLuongParameter);
        }
    
        public virtual int spThemPhong3(string tinhTrang, string maLoaiPhong, string ghiChu)
        {
            var tinhTrangParameter = tinhTrang != null ?
                new ObjectParameter("TinhTrang", tinhTrang) :
                new ObjectParameter("TinhTrang", typeof(string));
    
            var maLoaiPhongParameter = maLoaiPhong != null ?
                new ObjectParameter("MaLoaiPhong", maLoaiPhong) :
                new ObjectParameter("MaLoaiPhong", typeof(string));
    
            var ghiChuParameter = ghiChu != null ?
                new ObjectParameter("GhiChu", ghiChu) :
                new ObjectParameter("GhiChu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThemPhong3", tinhTrangParameter, maLoaiPhongParameter, ghiChuParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> spDoanhThuTheoNamTheoThang(Nullable<int> thang, Nullable<int> nam)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("Thang", thang) :
                new ObjectParameter("Thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("Nam", nam) :
                new ObjectParameter("Nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("spDoanhThuTheoNamTheoThang", thangParameter, namParameter);
        }
    
        public virtual int spThemPhongMoi(string tinhTrang, string maLoaiPhong, string ghiChu)
        {
            var tinhTrangParameter = tinhTrang != null ?
                new ObjectParameter("TinhTrang", tinhTrang) :
                new ObjectParameter("TinhTrang", typeof(string));
    
            var maLoaiPhongParameter = maLoaiPhong != null ?
                new ObjectParameter("MaLoaiPhong", maLoaiPhong) :
                new ObjectParameter("MaLoaiPhong", typeof(string));
    
            var ghiChuParameter = ghiChu != null ?
                new ObjectParameter("GhiChu", ghiChu) :
                new ObjectParameter("GhiChu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThemPhongMoi", tinhTrangParameter, maLoaiPhongParameter, ghiChuParameter);
        }
    }
}

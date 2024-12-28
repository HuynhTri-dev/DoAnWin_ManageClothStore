using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAnCuoiKi.model
{
    public partial class CuaHangDB : DbContext
    {
        public CuaHangDB()
            : base("name=CuaHangDB")
        {
        }

        public virtual DbSet<CHATLIEU> CHATLIEUx { get; set; }
        public virtual DbSet<CHITIETDONHANG> CHITIETDONHANGs { get; set; }
        public virtual DbSet<DANHMUC> DANHMUCs { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHUYENMAI> KHUYENMAIs { get; set; }
        public virtual DbSet<MAU> MAUs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUGIAOHANG> PHIEUGIAOHANGs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<THUONGHIEU> THUONGHIEUx { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHATLIEU>()
                .Property(e => e.MaCL)
                .IsUnicode(false);

            modelBuilder.Entity<CHATLIEU>()
                .HasMany(e => e.SANPHAMs)
                .WithRequired(e => e.CHATLIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHITIETDONHANG>()
                .Property(e => e.MaDH)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETDONHANG>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<DANHMUC>()
                .Property(e => e.MaDM)
                .IsUnicode(false);

            modelBuilder.Entity<DANHMUC>()
                .HasMany(e => e.SANPHAMs)
                .WithRequired(e => e.DANHMUC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaDH)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.LoaiDH)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaKM)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .HasMany(e => e.CHITIETDONHANGs)
                .WithRequired(e => e.DonHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonHang>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.DonHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonHang>()
                .HasMany(e => e.PHIEUGIAOHANGs)
                .WithRequired(e => e.DonHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.TongTien)
                .HasPrecision(20, 0);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaDH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KHUYENMAI>()
                .Property(e => e.MaKM)
                .IsUnicode(false);

            modelBuilder.Entity<MAU>()
                .Property(e => e.MaMau)
                .IsUnicode(false);

            modelBuilder.Entity<MAU>()
                .HasMany(e => e.SANPHAMs)
                .WithRequired(e => e.MAU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .HasMany(e => e.SANPHAMs)
                .WithRequired(e => e.NHACUNGCAP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.ChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaTK)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.DonHangs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUGIAOHANG>()
                .Property(e => e.MaPhieu)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUGIAOHANG>()
                .Property(e => e.MaDH)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUGIAOHANG>()
                .Property(e => e.Phi)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.GiaNhap)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.GiaBan)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MaDM)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MaMau)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MaCL)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MaTH)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CHITIETDONHANGs)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MaTK)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.TenTK)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.TAIKHOAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THUONGHIEU>()
                .Property(e => e.MaTH)
                .IsUnicode(false);

            modelBuilder.Entity<THUONGHIEU>()
                .HasMany(e => e.SANPHAMs)
                .WithRequired(e => e.THUONGHIEU)
                .WillCascadeOnDelete(false);
        }
    }
}

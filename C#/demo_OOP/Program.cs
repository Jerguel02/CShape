internal class Program
{

    // khai bao cac bien thanh vien (Fields)
    //Khai bao cac thuoc tinh (Properties)
    //khai bao cac phuong thua (Methods)
    private static void Main(string[] args)
    {
        
    }
}

internal class NhanVien
{
    private string maNhanVien;
    private string hoNhanVien;
     private string tenNhanVien;
    //Single heSoLuong;
    public double heSoLuong
    {
        get { return heSoLuong; }
        set { heSoLuong = value;}
    }
    public double tienLuongCoBan
    {
        get { return heSoLuong * 1200000;}
    }
    public void nhapNhanVien(string ma, string ho, string ten)
    {
        maNhanVien = ma;
        hoNhanVien = ho;
        tenNhanVien = ten;
    }
    //phuong thuc khoi tao (constructor)
    //phuong thuc dac biet co cung ten voi class chua no
    //phuong thuc khong co tham so
    public NhanVien()
    {
        maNhanVien = "001"; //mac dinh
        hoNhanVien = "Pham";
        tenNhanVien = "Nghia";
    }
    //trong 1 class co the chua nhieu Contructor
    public NhanVien(string ma, string ho, string ten)
    {
        maNhanVien = ma;
        hoNhanVien = ho;
        tenNhanVien = ten;
    }
    //NhanVien nv1 = new NhanVien();
    //NhanVien nv2 = new NhanVien("003", "Nguyen", "Nghia");
    NhanVien nv3 = new NhanVien
    {
    maNhanVien = "003", 
    hoNhanVien = "Pham",
    tenNhanVien = "Nghia",
    };

}
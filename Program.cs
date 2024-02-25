using System.Text;

namespace ThiTutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Menu();
        }
        static void Menu()
        {
            SinhVienService service = new SinhVienService();
            int chon;
            do
            {
                Console.WriteLine("------Menu--------");
                Console.WriteLine("1. Nhập 1 danh sách đối tượng.");
                Console.WriteLine("2. Xuất danh sách đối tượng ");
                Console.WriteLine("3. Xuất danh sách sinh viên được tặng vé vip HappyBee");
                Console.WriteLine("4. Xóa những sinh viên không được tham gia nếu không được tặng ");
                Console.WriteLine("5. Kế thừa");
                Console.WriteLine("6. Thoát");
                Console.WriteLine("--------------------");
                Console.Write("Mời bạn chọn chức năng: ");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("Bạn đã chọn chức năng 1");
                        service.Nhap();
                        break;
                    case 2:
                        Console.WriteLine("Bạn đã chọn chức năng 2");
                        service.Xuat();
                        break;
                    case 3:
                        Console.WriteLine("Bạn đã chọn chức năng 3");
                        service.DiemSinhVien();
                        break;
                    case 4:
                        Console.WriteLine("Bạn đã chọn chức năng 4");
                        service.XoaDSSinhVienKCoVeHappyBee();
                        break;
                    case 5:
                        Console.WriteLine("Kế thừa");
                        service.KeThua();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Mời bạn nhập lại trong khoảng từ 1 đến 6");
                        break;
                }
            } while (chon != 6);
        }
    }
}

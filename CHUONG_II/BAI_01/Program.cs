using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string Name = "Nguyen Le Nhut Quyen";
            string Name1 = "Nguyen Huu Nghi";
            char temp;
            string Name2;
            Console.WriteLine("Name: {0}",Name);
            Console.WriteLine("Name1: {0}",Name1);
            //1
            Console.WriteLine();
            Console.WriteLine($"Số ký tự trong chuỗi Name là: {DemSoKT(Name)}");
            //2
            Console.WriteLine();
            Console.WriteLine($"Số ký tự chữ hoa trong chuỗi Name là: {DemKTChuHoa(Name)}");
            //3
            Console.WriteLine();
            Console.Write("Nhập vào ký tự cần kiểm tra: ");
            temp = Char.Parse(Console.ReadLine());
            if(KTKTGiongNhau(Name, temp) == true)
            {
                Console.WriteLine("{0} có tồn tại trong chuỗi Name.",temp);
            }
            else
            {
                Console.WriteLine("{0} hông tồn tại trong chuỗi Name.", temp);
            }
            //4
            Console.WriteLine();
            Console.WriteLine("Chuỗi Name được đảo ngược là: {0}",ChuoiDaoNguoc(Name));
            //5
            Console.WriteLine();
            Console.WriteLine("Số ký tự chữ số trong chuỗi Name là: {0}",DemKTChuSo(Name));
            //6
            Console.WriteLine();
            Console.Write("Nhập vào ký tự cần đếm:");
            temp = char.Parse(Console.ReadLine());
            Console.WriteLine("Số lần xuất hiện của {0} trong chuỗi Name là: {1}", temp, DemSoKT(Name, temp));
            //7
            Console.WriteLine();
            Console.WriteLine("2 chuỗi trên có như nhau không?");
            Console.WriteLine(SoSanh2Chuoi(Name, Name1));
            //8
            Console.WriteLine();
            Console.WriteLine($"Email được tạo là: {Email(Name)}");
            //9
            Console.WriteLine();
            Console.WriteLine("Email trên có hợp lệ không?");
            Console.WriteLine(KiemTraEmail(Email(Name)));
            //10
            Console.WriteLine();
            Console.WriteLine("Chuỗi Name có hợp lệ không?");
            if (KiemTraChuoiHopLe(Name) == true)
            {
                Console.WriteLine("Chuỗi Name Hợp Lệ.");
            }
            else
            {
                Console.WriteLine("Chuỗi Name Không Hợp Lệ.");
            }
            //11
            Console.Write("\nNhập vào tên cần tạo username: ");
            Name2 = Console.ReadLine();
            Console.WriteLine($"Username được tạo: {username(Name2)}");
            Console.WriteLine($"Password được tạo: {Password(Name2)}");
        }
        
        //11
        static string Password(string a)
        {
            char[] pass = new char[0];
            int k = 0;
            Random r = new Random();
            var x = r.Next(0, 1000000);
            string s = x.ToString("000000");
            for (int i = 0; i < a.Length; i++)
            {
                if (KTKTHoa(a[i]) == true)
                {
                    Array.Resize(ref pass, pass.Length + 1);
                    pass[k] = a[i];
                    k++;
                }
            }
            return String.Concat(new string(pass).ToLower(), s);
        }
        static string username(string a)
        {
            char[] username=new char[0];
            int k = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if(a[i] ==' '&& k == 0)
                {
                    Array.Resize(ref username, a.Length - i);
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        username[k] = a[j];
                        k++;
                    }
                }
            }
            for (int l = 0; l < a.Length; l++)
            {
                if(a[l]==' ')
                {
                    break;
                }
                else
                {
                    Array.Resize(ref username, a.Length + 1);
                    username[k] = a[l];
                    k++;
                }
            }
            return new string (username);
        }
        //10
        static bool KiemTraChuoiHopLe(string a)
        {
            if((a[0]==' '||a[a.Length-1]==' ') && KTKTHoa(a[0]) == false)
            {
                return false;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]==' '&&a[i+1]==' ')
                {
                    return false;
                    break;
                }
                else if(a[i]==' '&& KTKTHoa(a[i + 1]) == false)
                {
                    return false;
                    break;
                }
            }
            return true;
        }
        //9
        static bool KiemTraEmail(string a)
        {
            foreach (char i in a)
            {
                if (i==' ' || i == '$' || i == '!' || i == '#' || i == '%' || i == '^' || i == '&' || i == '*')
                {
                    return false;
                    break;
                }
            }
            return true;
        }
        //8
        static string Email(string a)
        {
            return String.Concat(XoaKhoangTrang(a), "@.tdc.edu.vn");
        }
        static string XoaKhoangTrang(string a)
        {
            return a.Replace(" ","");
        }
        //7
        static bool SoSanh2Chuoi(string a, string b)
        {
            if(String.Compare(a, b) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //6
        static int DemSoKT(string a, char b)
        {
            int dem = 0;
            foreach (char c in a)
            {
                if (c == b)
                {
                    dem++;
                }
            }
            return dem;
        }
        //5 
        static int DemKTChuSo(string a)
        {
            int dem = 0;
            foreach (char i in a)
            {
                if(KTKTChuSo(i)==true)
                {
                    dem++;
                }    
            }
            return dem;
        }
        static bool KTKTChuSo(char a)
        {
            int temp = (char)a;
            if (temp >= 40 && temp <= 57)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //4
        static string ChuoiDaoNguoc(string a)
        {
            char[] b = a.ToCharArray();
            Array.Reverse(b);
            return new string(b);
            
        }
        //3
        static bool KTKTGiongNhau(string a, char b)
        {
            foreach (char c in a)
            {
                if(c == b)
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        //2
        static int DemKTChuHoa(string a)
        {
            int dem = 0;
            foreach (char c in a)
            {
                if (KTKTHoa(c) == true)
                {
                    dem++;
                }
            }
            return dem;
        }
        static bool KTKTHoa(char a)
        {
            if (char.IsUpper(a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //1
        static int DemSoKT(string a)
        {
            return a.Length;
        }
    }
}

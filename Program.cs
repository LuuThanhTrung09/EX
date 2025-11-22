using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Threading.Tasks.Dataflow;

namespace EX
{
    class Program
    {
        static void Main(string[] args)
        {
            // Baitap1();
            // Baitap2();
            // Baitap3();
            // Baitap4();
            // Baitap5();
            // Baitap6();
            // Baitap7();
            // Baitap8();
            // Baitap9();
            // Baitap10();
            // Baitap11();
            // Baitap12();
            // Baitap12();
            // Baitap13();
            // Baitap14();
            // Baitap15();
            // Baitap16();
            // Baitap17();
            // Baitap18();
            // Baitap19();
            // Baitap20();
            // Baitap21();
            // Baitap22();
            // Baitap23();
            // Baitap24();
            // Baitap25();
            // Baitap26();
            // Baitap27();
            // Baitap28();
            // Baitap29();
            // Baitap30();
            
        }

        //Cho trước số nguyên dương squareLength là kích thước của hình vuông. Bạn hãy viết chương trình để in ra chu vi và diện tích của hình vuông.
        private static void Baitap1()
        {
            Console.WriteLine("Nhap canh hinh vuong: ");
            int squareLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Canh hinh vuong la: {squareLength}");

            //chu vi hinh vuong
            int P = squareLength * 4;
            Console.WriteLine($"Chu vi hinh vuong la: {P}");

            //dien tich hinh vuong
            int S = squareLength * squareLength;
            Console.WriteLine($"Dien tich hinh vuong la: {S}");
        }

        //Cho trước hai số nguyên dương width và length lần là kích thước của hình chữ nhật. Bạn hãy viết chương trình để in ra chu vi và diện tích của hình chữ nhật.
        private static void Baitap2()
        {
            Console.WriteLine("Nhap chieu dai: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int width;
            while (true)
            {
                Console.WriteLine("Nhap chieu rong: ");
                width = Convert.ToInt32(Console.ReadLine());
                if (width == length) Console.WriteLine("Chieu rong khong duoc bang chieu dai. Vui long nhap lai !");
                else break;
            }
            Console.WriteLine($"Chieu dai la: {length}");
            Console.WriteLine($"Chieu rong la: {width}");

            //chu vi hinh chu nhat
            int P = (width + length) * 2;
            Console.WriteLine($"Chu vi hinh chu nhat: {P}");

            //dien tich hinh chu nhat
            int S = width * length;
            Console.WriteLine($"Dien tich hinh chu nhat la: {S}");
        }

        //Cho trước radius là bán kính của hình tròn. Bạn hãy viết chương trình để in ra chu vi và diện tích của hình tròn.
        //Lưu ý: Làm tròn đến chữ số thập phân thứ 2
        private static void Baitap3()
        {
            Console.WriteLine("Nhap ban kinh duong tron: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ban kinh duong trong la: {r}");

            //chu vi hinh tron
            double c = Math.Round(2 * r *3.14, 2);
            Console.WriteLine($"Chu vi hinh trong la: {c}");

            //dien tich hinh tron
            double s = Math.Round(3.14 * r * r, 2);
            Console.WriteLine($"Dien tich hinh tron: {s}");
        }

        /* Cho trước a là chiều dài cạnh đáy và h là chiều cao của 1 tam giác. Bạn hãy viết chương trình tính diện tích tam giác.
            Lưu ý: Làm tròn đến chữ số thập phân thứ 2
            Công thức tính diện tích tam giác S = a* h/2*/
        // Dạng 1:
        private static void Baitap4()
        {
            double a = 7;
            double h = 5;

            //dien tich tam giac
            double s = Math.Round(a * h/2 , 2);
            Console.WriteLine($"Dien tich hinh tam giac: {s}");
        }

        //Cho trước các số nguyên a, b, c là 3 cạnh của 1 tam giác. Bạn hãy viết chương trình tính chu vi và diện tích một tam giác.
        // Lưu ý: Làm tròn đến chữ số thập phân thứ 2
        // Công thức tính chu vi (C) là C = a+b+c
        // Công thức tính diện tích (S) là S = sqrt(p*(p-a)*(p-b)*(p-c)) với p = C/2

        //Dạng 2:
        private static void Baitap5()
        {
            int a = 2, b = 3, c = 4;

            //chu bi tam giac
            double C = a + b + c;
            Console.WriteLine($"Chu vi hinh tam giac la: {C}");

            //Nua chu vi
            double P = Math.Round(C/2, 2);
            Console.WriteLine($"Nua chu vi hinh tam giac: {P}");

            //dien tich cua tam giac
            double S = Math.Round(Math.Sqrt(P*(P-a)*(P-b)*(P-c)), 2);
            Console.WriteLine($"Dien tich hinh tam giac: {S}");
        }
        //Cho trước fahrenheit là nhiệt độ theo độ F (°F). Bạn hãy viết chương trình chuyển đổi nhiệt độ từ độ F (°F)  sang độ C (°C)
        //Lưu ý: Làm tròn 1 chữ số thập phân
        //công thức chuyển sang độ F sang độ C: C=(F-32)/1.8)
        private static void Baitap6()
        {
            double F = 50;

            //chuyen sang do c
            double C = Math.Round((F - 32) / 1.8, 1);
            Console.WriteLine($"Do F {F} sang do C la: {C}");
        }
        //Cho trước celsius là nhiệt độ theo độ C (°C). Bạn hãy viết chương trình chuyển đổi nhiệt độ từ độ C (°C) sang độ F (°F).
        //Lưu ý: Làm tròn 1 chữ số thập phân
        //Công thức chuyển từ độ C sang độ F là F = (C * 1.8) + 32
        private static void Baitap7()
        {
            double C = 20;

            //Chuyen tu do C sang do F
            double F = Math.Round((C * 1.8) + 32, 1);
            Console.WriteLine($"Do C {C} sang do F la: {F}");
        }

        //Cho trước base và exponent lần lượt là cơ số với số mũ. Bạn hãy viết chương trình để in ra lũy thừa của cơ số đó.
        private static void Baitap8()
        {
            int b = 2;
            int e = 3;

            //luy thua
            //Hàm Math.Pow theo định nghĩa sẽ trả về giá trị double
            //nêu khi khi báo kết quá int thì phải ép kiểu
            double R = Math.Pow(b,e);
            Console.WriteLine($"Ket qua luy thua la: {R}");
        }

        //Cho trước số nguyên dương n (n < 10). Bạn hãy viết chương trình để in ra tổng có dạng 
        //n + nn + nnn
        private static void Baitap9()
        {
            int n;
            while (true)
            {
                Console.WriteLine("Nhap n: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n >= 10 || n <= 0)
                {
                    Console.WriteLine("So khong hop le. Vui long nhap so nguyen duong n < 10.");
                }
                else break;
            }
            Console.WriteLine($"So n: {n}");
            //Tinh tong
            int nn = n * 10 + n;
            int nnn = n * 100 + n * 10 + n;
            int sum = n + nn + nnn;
            Console.WriteLine($"Tong la : {sum}");
        }
        //Cho trước ba số nguyên lần lượt là one, two, three. Bạn hãy viết chương trình để in ra số lớn nhất trong ba số đó
        private static void Baitap10()
        {
            Console.WriteLine("Nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"a = {a}");

             Console.WriteLine("Nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"b = {b}");

             Console.WriteLine("Nhap so c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"c = {c}");

            //So sanh 
            if(a > b && a > c) Console.WriteLine($"So lon nhat la: {a}");
            if(b > a && b > c) Console.WriteLine($"So lon nhat la: {b}");
            else Console.WriteLine($"So lon nhat la: {c}");

        }

        //Cho trước bốn số nguyên lần lượt là one, two, three, four. Bạn hãy viết chương trình để in ra số lớn nhất trong bốn số đó.
        private static void Baitap11()
        {
            Console.WriteLine("Nhap a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"a = {a}");

            Console.WriteLine("Nhap b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"b = {b}");

            Console.WriteLine("Nhap c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"c = ");

            Console.WriteLine("Nhap d: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"d = {d}");

            if(a > b && a > c && a > d) Console.WriteLine($"So lon nha la: {a}");
            if(b > a && b > c && b > d) Console.WriteLine($"So lon nha la: {b}");
            if(c > a && c > b && c > d) Console.WriteLine($"So lon nhat la: {c}");
            else Console.WriteLine($"So lon nhat la: {d}");

        }
        //Cho trước student là số học sinh của 1 lớp và fruit là số táo trong rổ. Bạn hãy viết chương trình để chia đều fruit cho tất cả student trong lớp và fruit còn dư lại.
        private static void Baitap12()
        {
            Console.WriteLine("Nhap hoc sinh: ");
            int student = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"So hoc sinh: {student}");

            Console.WriteLine("Nhap so keo: ");
            int candy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"So keo la: {candy}");

            int share = student / candy;
            int residual = student % candy;
            Console.WriteLine($"So keo duoc chia: {share} va so keo du la {residual}");
        }
        //Cho trước số nguyên dương n (n < 100). Bạn hãy viết chương trình để in ra chữ số đầu tiên và chữ số cuối cùng của n
        private static void Baitap13()
        {
            int n;
            while (true)
            {
                Console.WriteLine("Nhap n: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"So nguyen la: {n}");

                if (n >= 100 || n <= 0) Console.WriteLine($"So n khong duoc lon hon 100 va bang 0");
                else break;
            }

            int last = n % 10;
            int first = n / 10;
            Console.WriteLine($"First: {first}");
            Console.WriteLine($"Last: {last}");
        }
        //Cho trước một số nguyên có 3 chữ số là number. Bạn hãy viết chương trình để in ra 2 chữ số cuối và 2 chữ số đầu của number.
        private static void Baitap14()
        {
            int n;
            while (true)
            {
                Console.WriteLine("Nhap n: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"So n la: {n}");

                if(n < 100 ) Console.WriteLine($"Bat buoc phai 3 chu so. Vui long nhap lai !");
                else break;
            }
            
            int last = n % 100;
            int first = n / 10;
            Console.WriteLine($"First: {first}");
            Console.WriteLine($"Last: {last}");
        }

        //Cho trước hai số nguyên one và two (khác 0). Bạn hãy viết chương trình để in ra các phép toán cộng (+), trừ (-), nhân (x), chia (:) và chia lấy phần dư (%) trên 2 số đã cho. 
        //Lưu ý: kết quả của phép chia chỉ lấy hai chữ số thập phân
        private static void Baitap15()
        {
            Console.WriteLine("Nhap a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"a = {a}");

            Console.WriteLine("Nhap b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"b = {b}");
            
            int sum = a + b;
            Console.WriteLine($"Tong la: {sum}");

            int differece = a - b;
            Console.WriteLine($"Hieu: {differece}");

            int product = a * b;
            Console.WriteLine($"Tich: {product}");

            double quotient = Math.Round((double)a/b,2);
            Console.WriteLine($"Thuong: {quotient}");

            int remainder = a % b;
            Console.WriteLine($"So du la: {remainder}");
        }

        //Cho trước các số nguyên dương scoreOne, scoreTwo, scoreThree lần lượt là điểm số 3 môn thi của sinh viên. Bạn hãy viết chương trình để in ra điểm số cao nhất và điểm số trung bình của sinh viên.
        //Điểm số trung bình có một số thập phân
        private static void Baitap16()
        {
            Console.WriteLine("Nhap cot 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Cot diem a: {a}");

            Console.WriteLine("Nhap cot b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Diem cot b: {b}");

            Console.WriteLine("Nhap cot c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Diem cot c: {c}");

            int max = Math.Max(a, Math.Max(b,c));
            Console.WriteLine($"So lon nhat: {max}");

            double average = Math.Round((double)(a+b+c)/3,1);
            Console.WriteLine($"Diem trung binh: {average}");
        }
        
        //Cho trước số nguyên number là tổng số giây. Bạn hãy viết chương trình để in ra in ra giờ, phút, giây của number.
        private static void Baitap17()
        {
            Console.WriteLine("Nhap giay: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tong so giay la: {number}");

            int h = number/3600;
            int min = (number%3600)/60;
            int sec = number % 60;
            Console.WriteLine($"Thoi gian la: {h}:{min}:{sec}");
        }

        //chữ số hàng trăm
        private static void Baitap18()
        {
            Console.WriteLine("Nhap so nguyen: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"So nguyen cua ban la: {n}");

            int so_hang_tram = (n / 100) % 10;
            Console.WriteLine($"So hang tram cua ban la: {so_hang_tram}");
        }

        //Cho trước hai số nguyên dương lần lượt là: số bắt đầu start và số kết thúc end. 
        //Bạn hãy viết chương trình để in ra số ngẫu nhiên nằm trong khoảng từ start đến end.
        private static void Baitap19()
        {
            Console.WriteLine("nhap so bat dau: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"So bat dau cua ban la: {start}");

            Console.WriteLine("Nhap so ket thuc: ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"So ket thuc cua ban la: {end}");

            Random random = new Random();
            int number = random.Next(start, end);
            Console.WriteLine($"So tu {start} den so {end}, so ngau nhien la: {number}");
        }
        //Cho trước số nguyên yourNumber, biết rằng yourNumber sẽ thuộc vào một trong ba loại sau đây: nguyên dương, nguyên âm và số 0. Bạn hãy viết chương trình để in ra loại số của yourNumber.
        private static void Baitap20()
        {
            Console.WriteLine("Nhap so nguyen: ");
            int yourNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"So nguyen cua ban la: {yourNumber}");

            if (yourNumber > 0 ) Console.WriteLine($"So {yourNumber} la so nguyen duong");
            if (yourNumber < 0 ) Console.WriteLine($"So {yourNumber} la so nguyen am");
            if (yourNumber == 0) Console.WriteLine("So cua ban la so 0");
        }

        //Cho trước số nguyên yourNumber (yourNumber > 0), biết rằng yourNumber sẽ thuộc vào một trong hai loại sau đây: số chẵn, số lẻ. Bạn hãy viết chương trình để in ra loại số của yourNumber
        private static void Baitap21()
        {
            Console.WriteLine("nhap so: ");
            int yourNumber = Convert.ToInt32(Console.ReadLine());
            if (yourNumber % 2 == 0) Console.WriteLine($"So {yourNumber} la so chan");
            else Console.WriteLine($"So {yourNumber} la so le");
        }

        //Cho trước số nguyên yourNumber, biết rằng yourNumber sẽ thuộc vào một trong bốn loại sau đây: nguyên dương chẵn, nguyên dương lẻ, nguyên âm chẵn và nguyên âm lẻ. Bạn hãy viết chương trình để in ra loại số của yourNumber
        private static void Baitap22()
        {
            Console.WriteLine("Nhap so: ");
            int yourNumber = Convert.ToInt32(Console.ReadLine());
            if (yourNumber >= 0)
            {
                if (yourNumber % 2 == 0)
                {
                    Console.WriteLine($"So {yourNumber} la so duong chan");
                }
                else Console.WriteLine ($"So {yourNumber} la so duong le");
            }
            else
            {
                if (yourNumber % 2 == 0)
                {
                    Console.WriteLine($"So {yourNumber} la so am chan");
                }
                else
                {
                    Console.Write($"So {yourNumber} la so am le");
                }
            }
        }

        //Cho trước số nguyên dương yourAge là tuổi của khách hàng khi đến xem phim. Bạn hãy viết chương trình để in ra thông báo tùy thuộc vào tuổi của họ: 

        // “Bạn được xem phim Thế giới lập trình” hoặc 
        // “Bạn KHÔNG được xem phim Thế giới lập trình” 
        // Biết rằng:

        // yourAge là số nguyên dương, nhỏ hơn 100.
        // Quy định xem phim chỉ chấp nhận khách hàng có tuổi từ 15 trở lên. 
        private static void Baitap23()
        {
            Console.WriteLine($"Nhap so: ");
            int yourAge;
            while (true)
            {
                yourAge = Convert.ToInt32(Console.ReadLine());
                if (yourAge  > 100)
                {
                    Console.WriteLine($"Tuoi khong duoc lon hon 100. Moi nhap lai !");
                }
                if (yourAge >= 15)
                {
                    Console.WriteLine($"Ban duoc xem phim The gioi lap trinh");
                }
                else
                {
                    Console.WriteLine("ban khong duoc xem phim the gioi lap trinh");
                }
            }
        }

        //Cho trước 3 số nguyên dương X, Y, Z lần lượt là độ dài 3 cạnh của 1 tam giác. Bạn hãy viết chương trình để kiểm tra 3 cạnh đó có thỏa mãn bất đẳng thức tam giác hay không?
        // Bất đẳng thức tam giác cho biết rằng: Trong một tam giác bất kỳ, tổng độ dài hai cạnh bao giờ cũng lớn hơn độ dài cạnh còn lại.
        // Ví dụ: Trong tam giác ABC với 3 cạnh lần lượt là AB, AC và BC ta có:
        // AB + AC > BC
        // AB + BC > AC
        // AC + BC > AB
        // x = AB, y = AC, z = BC
        private static void Baitap24()
        {
            Console.WriteLine("Nhap x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"x = {x}");

            Console.WriteLine("Nhap y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"y = {y}");

            Console.WriteLine("Nhap z: ");
            int z= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"z = {z}");

            if (x + y > z && y + z > x && x + z > y) Console.WriteLine("True");
            else Console.WriteLine("False");
            
        }

        //Cho trước 3 số nguyên dương X, Y, Z lần lượt là độ dài 3 cạnh của 1 tam giác (đã thỏa mãn điều kiện tổng độ dài 2 cạnh luôn hơn độ dài cạnh còn lại) Bạn hãy viết chương trình để kiểm tra loại của tam giác đó, biết rằng:
        // Tam giác đều có độ dài 3 cạnh bằng nhau.
        // Tam giác cân có độ dài 2 cạnh bên bằng nhau.
        // Tam giác vuông là tam giác có bình phương độ dài 1 cạnh bằng tổng bình phương 2 cạnh còn lại.
        // Tam giác thường không thuộc các loại trên là tam giác nhọn.
        private static void Baitap25()
        {
            Console.WriteLine("Nhap x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"x = {x}");

            Console.WriteLine("Nhap y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"x = {y}");

            Console.WriteLine("Nhap z: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"x = {z}");

            if (x == y && y == z && z == x) Console.WriteLine("Tam giac deu");
            if (x == y || x == z || y == z) Console.WriteLine("Tam giac can");
            if (x*x == y*y + z*z || y*y == x*x + z*z || z*z == x*x + y*y) Console.WriteLine("Tam giac vuong");
            else Console.WriteLine("Tam giac thuong");
        }

        //Cho trước score là điểm số trung bình của học sinh. Bạn hãy viết chương trình để in ra xếp loại của học sinh đó.

        // score  >= 9.0: Xuất sắc
        // score  >= 8.0: Giỏi
        // score  >= 5.5: Khá 
        // score  >= 4.0: Trung bình
        // score  < 4.0: Yếu

        private static void Baitap26()
        {
            Console.WriteLine("Nhap diem: ");
            double score = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Diem: {score}");

            if (score >= 9) Console.WriteLine("Hoc sinh gioi");
            else if (score >= 5.5) Console.WriteLine("Hoc sinh kha");
            else if (score >= 4) Console.WriteLine("Hoc sinh trung binh");
            else Console.WriteLine("Hoc sinh yeu");
        }

        //Cho trước age là tuổi của một người (0<tuổi<=120). Bạn hãy viết chương trình để in ra age của người đó thuộc loại nào sau đây.

        // age <=11: Thieu nhi
        // 11 < age <=25: Thieu nien
        // 25< age <=50: Trung nien 
        // age >50: Lao nien

        private static void Baitap27()
        {
            Console.WriteLine("Nhap tuoi: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            if (age <= 11) Console.WriteLine("Thieu nhi");
            else if (11 < age && age <= 25 ) Console.WriteLine("Thieu nien");
            else if (25 < age && age <= 50) Console.WriteLine("Trung nien");
            else Console.WriteLine("Lao nien");
        }

        //Cho trước số nguyên dương year là giá trị của năm. Bạn hãy viết chương trình để in ra year có phải là năm nhuận hay không? Biết year là năm nhuận khi nó thỏa mãn một trong hai điều kiện dưới đây:

        // year chia hết cho 400
        // year chia hết cho 4 nhưng không chia hết cho 100

        private static void Baitap28()
        {
            Console.WriteLine("Nhap nam: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Nam do la nam nhuan");
            }
            else Console.WriteLine("Nam do khong phai la nam nhuan");
        }

        //Cho trước số nguyên dương totalSale là doanh số bán hàng tại cửa hàng của Lân, Lân là nhân viên sale sẽ nhận được hoa hồng theo doanh số. Bạn hãy viết chương trình để in ra hoa hồng mà Lân nhận được, với hoa hồng được tính như sau:

        // 5% nếu tổng doanh số bán hàng nhỏ hơn hoặc bằng 100$
        // 10% nếu tổng doanh số bán hàng nhỏ hơn hoặc bằng 300$
        // 20% nếu tổng doanh số bán hàng lớn hơn 300$

        private static void Baitap29()
        {
            Console.WriteLine("Nhap doanh so: ");
            double totalSale = Convert.ToDouble(Console.ReadLine());

            if (totalSale < 100)
            {
                double percent1 = 5;
                double sale1 = (totalSale * percent1) /100;
                Console.WriteLine($"Hoa hong duoc nhan: {sale1}");
                return;
            }
            if (totalSale < 300)
            {
                double percent2 = 10;
                double sale2 = (totalSale * percent2) / 100;
                Console.WriteLine($"Hoa hong nhan duoc: {sale2 }");
                return;
            }
            if (totalSale > 300)
            {
                double percent3 = 20;
                double sale3 = (totalSale * percent3) / 100;
                Console.WriteLine($"Hoa hong nhan duoc la: {sale3}");
                return;
            }
        }
        // Cho trước character là một kí tự bất kỳ. Bạn hãy viết chương trình để in ra character đã cho có phải là nguyên âm hay không? 

        // Các nguyên âm gồm có: a, e, i, o, u, A, E, I, O, U.

        private static void Baitap30()
        {
            Console.WriteLine("Nhap ki tu: ");
            char c = Console.ReadKey().KeyChar;

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' ) Console.WriteLine($"\n Ki tu {c} la nguyen am");
            else Console.WriteLine($"\n Ki tu {c} khong phai la nguyen am");
        }
    }   
}


using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// nhập out đê kiểm tra nhập hợp lệ
// nhâp khi nào đúng mới dừng
int n;
Console.WriteLine("nhâp n >= 0");
String s = Console.ReadLine();
if (int.TryParse(s, out n) == false)
{
    Console.WriteLine("bạn phải nhập số ");

}
else
{
    if(n <  0)
    {
        Console.WriteLine("Tui đã nói  N phải >= 0  mà");
    }
    else
    {
        // tính giai thừa 
        int gt = 1;
        for (int i = 1; i <= n; i++)
            gt = gt * i;
        Console.WriteLine($"{n}!= {gt}");
    }
}
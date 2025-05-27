// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
void giai_bac1(double a , double b)
{
    if (a == 0 && b == 0)

        Console.WriteLine("phuong trinh vo nghiem");
    else if (a == 0 && b != 0)
        Console.WriteLine("phương tring vô nghiêm ");
    else
        Console.WriteLine("X = {0} " , -b / a);
}
void giai_bac2 (double a , double b , double c)
{
    if (a == 0)
    {
        giai_bac1(a, b); 
    }
    else
    {
        var delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta < 0)
            Console.WriteLine("phuong trinh vo nghiem");
        else if (delta == 0 )
        {
            var x = -b / (2 * a);
            Console.WriteLine("phuong trinh co nghiem X ={0} " ,x);
        }
        else
        {
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt: x1 = {0}, x2 = {1}", x1 , x2);
            }
        }
            
    }
}

Console.WriteLine(" chao mung den pt bac 2");
Console.WriteLine("nhap he so a");
var a = Double.Parse(Console.ReadLine());
Console.WriteLine("nhap he so b");
var b = Double.Parse(Console.ReadLine());
Console.WriteLine("nhap he so c");
var c = Double.Parse(Console.ReadLine());
Console.WriteLine("{0}X^2 + {1}X + {2}= 0", a,b,c);
giai_bac2(a, b, c);
Console.ReadLine();

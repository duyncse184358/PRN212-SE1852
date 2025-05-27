using System.Text;

String do_math (double a, double b, String op)
{
    String result = "";
    switch (op)
    {
        case "+":
            result = a + "+" + b + "=" + (a + b);
            break;
        case "-":
            result = a + "-" + b + "=" + (a - b);
            break;
        case "*":
            result = a + "*" + b + "=" + (a * b);
            break;
        case "/":
            if(b==0)
                result ="mẫu không hợp lệ";
            else
            result = a + "/" + b + "=" + (a / b);
            break;
        default:
            result = "nhập tào lao rồi";
            break;
    }
    return result;

}
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("nhap so a");
var a = Double.Parse(Console.ReadLine());
Console.WriteLine("nhap so b");
var b = Double.Parse(Console.ReadLine());
Console.WriteLine(" nhap phép toán +,-,*,/:");
String op = Console.ReadLine();
String result = do_math(a, b ,op);
Console.WriteLine(result);
Console.ReadLine();

// dạng mới nhận nhiều giá trị cùng một lúc
int sum (params int[] arr)
{
    int s = 0;
    
        foreach (int x in arr)
            s += x;
        return s;
    

}

int s1 = sum(1);
int s2 = sum(1, 8);
int s3 = sum(12, 5, 10);
Console.WriteLine($"s1 = {s1} ; s2 = {s2} ; s3 = {s3}");  
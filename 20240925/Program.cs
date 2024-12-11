/*學號: 1110410024姓名: 許欣婷*/
using System.Collections;
using System;

class Program
{
    // 圓周率函式：使用 Leibniz 公式計算 π
    static double CountPi(int n)
    {
        if (n < 4 || n > 15)
        {
            return -1; // 回傳錯誤值
        }

        double pi = 0.0;
        int sign = 1; // 控制正負號
        for (int k = 0; k <= n; k++)
        {
            pi += sign * 1.0 / (2 * k + 1); // 計算當前項
            sign = -sign; // 變更正負號
        }
        return pi * 4;
    }

    // 計算圓周函式
    static double GetCircumference(double r, double pi)
    {
        return 2 * pi * r; // 計算圓周長公式：2πr
    }

    // 計算圓面積函式
    static double GetCircleArea(double r, double pi)
    {
        return pi * r * r; // 計算圓面積公式：πr²
    }

    // 主程式
    static void Main(string[] args)
    {
        Console.Write("請輸入圓的半徑: ");
        if (!double.TryParse(Console.ReadLine(), out double radius))
        {
            Console.WriteLine("輸入的半徑無效，程式結束!");
            return;
        }

        Console.Write("請輸入圓周率的精度 (4 <= n <= 15): ");
        if (!int.TryParse(Console.ReadLine(), out int precision))
        {
            Console.WriteLine("輸入的精度無效，程式結束!");
            return;
        }

        // 計算圓周率
        double pi = CountPi(precision);

        // 檢查精度是否正確
        if (pi == -1)
        {
            Console.WriteLine("錯誤: 輸入的精度不在合法範圍內，程式結束!");
            return;
        }

        // 顯示圓周率
        Console.WriteLine($"使用精度 n = {precision} 計算的圓周率為: {pi}");

        // 計算圓周長與圓面積
        double circumference = GetCircumference(radius, pi);
        double area = GetCircleArea(radius, pi);

        // 輸出結果
        Console.WriteLine($"圓的周長為: {circumference}");
        Console.WriteLine($"圓的面積為: {area}");
    }
}

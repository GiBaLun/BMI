using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 輸入身高
            Console.WriteLine("請輸入您的身高(cm)");
            
            double tall = double.Parse(Console.ReadLine());
            
            // 輸入體重
            Console.WriteLine("請輸入您的體重(kg)");

            double weight = double.Parse(Console.ReadLine());

            // 輸出BMI
            int BMI = (int)(weight / Math.Pow((tall / 100), 2));
            Console.WriteLine("您的BMI是" + BMI );

            // 輸出狀態
            string now;
            if (BMI < 18.5)
                now = "過輕";
            else if(BMI >= 28)
                now = "過重";
            else
                now = "正常";
            Console.WriteLine("您的狀態是" + now);

            // 免役與否
            string soldier;
            if (BMI > 31.5)
                soldier = "免役";
            else if (BMI < 16.5)
                soldier = "免役";
            else
                soldier = "正常兵役";
            Console.WriteLine("您" + soldier);

            Console.Read();
        }
    }
}

using System;




namespace Ticket9
{
    class Program
    {
        public static void Main()
        {
            //создаем переменые 
            double a,b,c,D;
            //считываем данные для дискриминантаы
            System.Console.WriteLine("даанные для дескриминанта");
            double.TryParse(Console.ReadLine(),out a); 
            double.TryParse(Console.ReadLine(),out b);
            double.TryParse(Console.ReadLine(),out c);
           
           D = Math.Round((b*b)-(4*a*c),5);
           
            //вывод возможные варианты треугольников
            if(D>0) System.Console.WriteLine("два корня");
            else if(D == 0)  System.Console.WriteLine("один корень");
            else  System.Console.WriteLine("такой ответ не предусмотрен");
            
            
        }
    } 
    
}
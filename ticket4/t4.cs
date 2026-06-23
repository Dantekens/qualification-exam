using System;




namespace Ticket4
{
    class Program
    {
        public static void Main()
        {
            //создаем переменые 
            double a,b,c,d;
            //считываем стороны трапеции
            System.Console.WriteLine("введите 2 основания");
            double.TryParse(Console.ReadLine(),out a); 
            double.TryParse(Console.ReadLine(),out b);
            System.Console.WriteLine("введите боковую сторону");
            double.TryParse(Console.ReadLine(),out c);
            System.Console.WriteLine("введите диагональ");
            double.TryParse(Console.ReadLine(),out d);
           
           //проверяем существует ли трапеция
            if(c <= Math.Abs(a-b)/2 || Math.Round(a,5) == Math.Round(b,5) )
            {
                System.Console.WriteLine("Ошибка: ТРАПЕЦИЯ с такими сторонами не существует");
                return; 
            }
            //округляем
            double side1 = Math.Round(d * d,5);
            double side2 = Math.Round((a*b)+(c*c),5);
            //вывод возможные варианты трапеции
            if(side1 == side2) System.Console.WriteLine("трапеция равнобокая");
            else System.Console.WriteLine("трапеция не равнобокая");
        }
    } 
    
}
using System;



namespace Ticket3
{
    class Program
    {
        public static void Main()
        {
            //создаем переменые 
            double side1,side2,side3;
            //считываем 3  стороны
            System.Console.WriteLine("введите 3 стороны");
            double.TryParse(Console.ReadLine(),out side1); 
            double.TryParse(Console.ReadLine(),out side2);
            double.TryParse(Console.ReadLine(),out side3);
           
           //проверяем существует ли треугольник
            if ((side1 + side2 <= side3) || (side1 + side3 <= side2) || (side2 + side3 <= side1))
            {
                System.Console.WriteLine("Ошибка: Треугольник с такими сторонами не существует");
                return; 
            }

            
            
            double result_C =Math.Round(c ,5);
            double result_A =Math.Round(a,5);
            double result_B =Math.Round(b,5);
            //вывод возможные варианты треугольников
            if(result_C == result_A&&result_C==result_B) System.Console.WriteLine("треугольник равнестороний");
            else if(result_C == result_A|| result_C == result_B|| result_A == result_B) System.Console.WriteLine("треугольник равнобедреный");
            else System.Console.WriteLine("неизвестный разностороний");
    }
        } 
    }
}
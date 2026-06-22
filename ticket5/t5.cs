using System;




namespace Ticket5
{
    class Program
    {
        public static void Main()
        {
            //создаем переменые 
            int x,y,z;
            //считываем 3  стороны
            System.Console.WriteLine("введите баллы за экзамен");
            int.TryParse(Console.ReadLine(),out x); 
            int.TryParse(Console.ReadLine(),out y);
            int.TryParse(Console.ReadLine(),out z);
           
           
           //проверяем существует ли треугольник
            if(x < 0 ||y<0|| z<0)
            {
                System.Console.WriteLine("Ошибка: таких баллов не ту");
                return; 
            }
            //вывод возможные варианты треугольников
            if((x+y+z)>26) System.Console.WriteLine("зачислен");
            else System.Console.WriteLine("не зачислен");
        }
    } 
    
}
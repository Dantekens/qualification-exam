using System;




namespace Ticket7
{
    class Program
    {
        public static void Main()
        {
            //создаем переменые 
            int x,y,r;
            //считываем балы
            System.Console.WriteLine("балы за экзамен");
            int.TryParse(Console.ReadLine(),out x); 
            int.TryParse(Console.ReadLine(),out y);
            int.TryParse(Console.ReadLine(),out r);
           
           
           //проверяем чтобы балы небыли меньше нуля
            if(x < 0 ||y<0|| r<0)
            {
                System.Console.WriteLine("Ошибка: таких баллов не ту");
                return; 
            }
            double res = (x+y+r) / 3.0;
            //выводим на какую оценку сделано
            if(res>4) System.Console.WriteLine("отлично");
            else if(res <= 4 && res >  3) System.Console.WriteLine("хорошо");
            else System.Console.WriteLine("плохо");
            
        }
    } 
    
}
namespace Arrays_InputOtput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Декларирам масив от 13 елемента
            double[] grades = new double[13];// { 1,2,3,4};
            string[] names = new string[13] { "Lubo",
                "Milen","Misho","Radko","Svetlomir",
                "Siana", "Silvia", "Svetlomir","TEDO",
                "Hristian","Hristomir","Cvetelina","Cvetina"};
          //Въвеждат се елементите от клавиатурата -цикъл
          for (int index=0; index < grades.Length; index++)
            {
                Console.Write($"{index+14}. {names[index]} e ==> ");
                grades[index] = double.Parse(Console.ReadLine());
            
            }
            //Обработка
            grades[9] = 6;
            names[8] = "Teodor";
            grades[1] = Math.Ceiling(5.234);
            Console.WriteLine($"{names[1]}'s grade is {grades[1]}");
            grades[6] = 5;
            //Отпечатване на резултите
            for(int j =0; j < names.Length; j++)
            {
                Console.WriteLine($"{j+14}. {grades[j]}");
            }
        }
    }
}

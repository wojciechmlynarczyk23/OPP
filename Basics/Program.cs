namespace Basics
{
    internal class Program
    {
         class Group(string name, int count, string mainTeacher, Array students)
        {
            private string name = name;
            private int count = count;
            private string mainTeacher = mainTeacher;
            private Array students = students;
        }

        static void Main(string[] args)
        {
           Group g1 = new Group("5c",20,"Obsti");
           Group g2 = new Group("5b", 24, "Radar");

            Random rnd = new Random();
            int wynik = rnd.Next(1, 3);

            if (wynik == 1)
            {
                Console.WriteLine("wygrywa " + g1.mainTeacher + " z klasy " + g1.name);
            }
            else if (wynik == 2)
            {
                Console.WriteLine("wygrywa " + g2.mainTeacher + " z klasy " + g2.name);
            }
        }
    }
}

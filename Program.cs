
namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var franct1 = new Fraction(3, 2);
            var franct2 = new Fraction(4, 3);
            var complx1 = new СmplxNum(2, 4, "+");
            var complx2 = new СmplxNum(3, 1, "+");
            var birthday1 = new BirthDay(12,04,1999);
            ClFranction cl = new ClFranction();
            ClСmplxNum cl2 = new ClСmplxNum();
            ClBirthDay cl3 = new ClBirthDay();
            int whil = 0;
            while (whil <= 0)
            {
                Console.WriteLine("\nChoose Task 1-3 or 4 to exit: ");
                int swh = int.Parse(Console.ReadLine());
                switch (swh)
                {
                    case 1:
                        Console.WriteLine("Frunct 1: " + franct1.ToString());
                        Console.WriteLine("Frunct 2: " + franct2.ToString());
                        cl.Add(franct1, franct2);
                        cl.Subtraction(franct1, franct2);
                        cl.Multi(franct1, franct2);
                        cl.Division(franct1, franct2);
                        break;
                    case 2:
                        Console.WriteLine("Complex Number 1: " + complx1.ToString());
                        Console.WriteLine("Complex Number 2: " + complx2.ToString());
                        cl2.Add(complx1, complx2);
                        cl2.Subtraction(complx1, complx2);
                        cl2.Multi(complx1, complx2);
                        cl2.Division(complx1, complx2);
                        break;
                    case 3:
                        Console.WriteLine("Birth Day: " + birthday1.ToString());
                        cl3.NextWeekInYear(birthday1);
                        cl3.NextDayInWeek(birthday1,2024);
                        cl3.DayToBirthDay(birthday1);
                        break;
                    case 4:
                        whil = 1;
                        break;
                }
            }
        }
    }
}
/*var point = new Point(5, 7);
            Console.WriteLine(point.ToString());

            var today = DayOfWeek.Sunday;
            Console.WriteLine(today);

            var user = new User()
            {
                Name = "Test",
                Email = "Test@gmail.com",
                Age = 25,
                DayOfWeek = DayOfWeek.Sunday
            };
            if(user.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine(user.Name);
            }
        */
/*class User
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public int Age {  get; set; }
            public DayOfWeek DayOfWeek { get; set; }
        }
        public enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public override string ToString() => $"{X},{Y}";
        }*/
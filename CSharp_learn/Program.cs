namespace learning
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(Math.Sqrt(25));
            Console.WriteLine("Ведите радиус круга: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = returnDouble(radius);
            Console.WriteLine("Площадь круга с радиусом {0} равна {1}", radius, area);

            Study student = new Study("name", 29);
            student.age = 40;
        }

        static double returnDouble(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;

        }
    }
    class Study
    {
        private string name { get; set; }

        public int age { get; set; }

        public Study(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        private string privateMethod()
        {

            return name;
        }

        public void publicMethod()
        {
            Console.WriteLine(privateMethod());
        }
        
    }
}
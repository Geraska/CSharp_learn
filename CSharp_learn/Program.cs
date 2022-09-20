namespace learning
{
    class Program
    {
        static void Main()
        {
            //byte[] nums = { 1, 4, 6, 3, 6, 10 };
            //byte number = countSum(nums);
            //Console.WriteLine("Result: " + number);  
            //string word = "Hello!";

            //word = String.Concat(word, "!!");
            //Console.WriteLine(String.Compare(word, "Hello!!"));
            //string people = "Alex,Bob,John";
            //string[] names = people.Split(new char[] { ',' });
            //people = String.Join(" ", names);
            //Console.WriteLine(people);
            //Console.WriteLine(word.Substring(0));
            //Console.WriteLine("Enter a text: ");
            //string text = Console.ReadLine();
            //using (FileStream stream = new("info.txt", FileMode.OpenOrCreate))
            //{
            //    byte[] array = System.Text.Encoding.Default.GetBytes(text);

            //    stream.Write(array, 0, array.Length);
            //}

            //using FileStream stream1 = File.OpenRead("info.txt");
            //{
            //    byte[] array = new byte[stream1.Length];
            //    stream1.Read(array, 0, array.Length);

            //    string textFromFile = System.Text.Encoding.Default.GetString(array);
            //    Console.WriteLine(textFromFile);
            //}

            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
            }
            catch(FormatException)
            {
                Console.WriteLine("You entered wrong format!");
            }
        }

        //private static byte countSum(byte[] numbers)
        //{
        //    short sum = 0;   
        //    foreach(byte b in numbers)
        //        sum += b;
        //    return Convert.ToByte(sum);
        //}
    }
}
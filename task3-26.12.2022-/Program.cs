namespace task3_26._12._2022_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. 5 reqemli eded verilib.Bu ededin evveline 4 reqemini , axirinada 2 reqemini artir.
            //Giris: 16538
            //Cixis: 4165382

            Console.Write("5 reqemli eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            if(a>=10000 && a<=99999)
            {
                a = a + 400000;
                a = a * 10 + 2;
                Console.Write(a);

            }
            else Console.WriteLine("daxil etdiyiniz eded 5 reqemli deyil!");
        }
    }
}
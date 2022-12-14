namespace DST02
{
    class Program
    {
        static void Main() 
        {
            //int a = 10;
            //bool b = false;
            //float f = 10.5f;
            //double d = 5.021;
            //decimal de = 5.555m;

            //a = Convert.ToInt16(d);

            //Console.WriteLine("Hello World "+ d.ToString().GetType());
            //Console.WriteLine("Hello World {0}", a);

            //object x = 10.06;
            //dynamic y = 20.5;

            //Console.WriteLine(x.GetType());
            //Console.WriteLine(y.GetType());

            //int zz = 10, yy = 20; 

            //var z = 10;
            //Console.WriteLine(zz.GetType());
            //Console.WriteLine(z.GetType());

            //Guid guid= Guid.NewGuid();  
            //Console.WriteLine(guid.ToString());
            //Console.WriteLine(guid);

            //DateTime dd = DateTime.Now;
            //Console.WriteLine(dd);

            //Guid obj = Guid.NewGuid();
            //Console.WriteLine("New Guid is " + obj.ToString());
            //Console.ReadLine();

            //double age = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(age);

            //ConsoleKeyInfo d = Console.ReadKey();
            //Console.WriteLine(d.Key);

            //string name = "";
            ////Console.WriteLine("This is " + name.Remove(0, 4));
            //if (string.IsNullOrEmpty(name)) // Null and Empty Check
            //{
            //    Console.WriteLine("No Name");
            //}
            //else
            //{
            //    Console.WriteLine(name);
            //}

            string name = "   ";
            if(string.IsNullOrWhiteSpace(name)) //Null, Empty ANd WhiteSpace Check
            {
                Console.WriteLine("No Name Found");
            }
            else
            {
                Console.WriteLine(name);
            }


        }
    }
}
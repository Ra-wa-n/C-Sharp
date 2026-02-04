using System.Collections;

namespace lab5_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            Person p1 = new Person
            {
                Id = 1,
                Name = "Test",
            };
            p1.Print();
            //task 2
            Rectangle rect1 = new Rectangle(5, 10, "Red", "cm", 1);
            Console.WriteLine(rect1.Area);
            rect1.Width = 4; rect1.Height = 4;
            Console.WriteLine(rect1.Area);
            //task 3
            Gradebook gradebook = new Gradebook();
            gradebook.Grades = new int[3];
            gradebook[0] = 50;
            gradebook[1] = 60;
            gradebook[2] = 70;
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(gradebook[i]);
            }
            // task 4
            StringIndexer s = new StringIndexer(4);
            s[0] = "rawan";
            s[1] = "pd";
            s[2] = "alex";
            s["name"] = "Na";
            s["track"] = "os";
            Console.WriteLine(s[2]);
              Console.WriteLine(s["track"]);
            //task 5
            ArrayList cart = new ArrayList();
            cart.Add(p1);
            cart.Add("rawan");
            cart.Add(123);
            foreach (var i in cart)
            {
                Console.WriteLine(i);
            }
            int count = cart.Count;
            Console.WriteLine(count);
            //cart.Sort(); error can not compare different type
            Console.WriteLine(cart.Contains(p1));
            cart.Reverse();
            foreach (var item in cart)
            {
                Console.WriteLine(item);
            }
            // task 6
            var list = new List<Person>
            {
                 new Person {Id=1,Name="rawan"},
                 new Person { Id = 2, Name = "Omar" },
                 new Person { Id = 3, Name = "Ali" }
            };
            list.Sort((a, b) => b.Name.CompareTo(a.Name));
            // list.Add(123); error 
            list.Add(p1);
            list.ForEach(x => x.Print());
            // task 7
            Console.WriteLine("//////////////");
            Calculator(3, 0);
            //task 8
            ReadFromFile("file");

        }
        public static void Calculator( int p1, int p2)
        {
            try
            {
                int res = p1 / p2;
                Console.WriteLine(res);
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            //?
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("error");

            }
        }
        public static void ReadFromFile( string filename)
        {
            FileStream file = null;

            try
            {
            file=  File.Open(filename, FileMode.Open, FileAccess.Read);
                Console.WriteLine(File.ReadAllText(filename));
            }
            catch (FileLoadException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("Unexpected error");
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
        }

    }
}

using System.Xml.Linq;

namespace lab6_c_
{
    internal class Program
    {
       public delegate void Messege();
        public delegate bool IntFilter(int x);
        static void Main(string[] args)
        {
            //task 1
            double res1 = Calculate((a, b) => a + b);
            Console.WriteLine(res1);
            double res2 = Calculate((a, b) => a - b);
            Console.WriteLine(res2);
            double res3 = Calculate((a, b) => a * b);
            Console.WriteLine(res3);
            //task 2
            Messege ms1 = sendmessege;
            ms1 += sendEmail;
            ms1();
            ms1 -= sendmessege;
            // task 3
            int[] array = { 1, 3, 6, 7, 9, 4, 6 };
            List<int> list = FilterArray(array, a => a > 1);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            // task 4
            print(4, delegate () { Console.WriteLine(4 * 2); });
            // task 5
            List<int> list1 =  new List<int>{1,2,34,6,8,10};   
            List<int> list2 = EvenNum(list1);
            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("/////////////");
           List<int> res=  list1.Where(n=> n>8).ToList();
            foreach (int i in res)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(list1.Exists(n => n < 0));
           // task 6
            List<Person> pers= new List<Person>() {
                new Person {Name ="rawan",  Age = 23 },
                new Person{Name ="ali" ,Age =24},
            };
         pers.Sort((a,b)=> b.Age.CompareTo(a.Age));
            foreach (Person p in pers)
            {
                Console.WriteLine(p.Name);
            }
            // task 7
            TemperatureSensor sensor= new TemperatureSensor();
            sensor.SensorChanged += Sensor_SensorChanged;
            sensor.SetTemp(-34);
            // task 8
            Button btn = new Button();
            Form form = new Form();
            Logger logger = new Logger();
            btn.OnClick += form.OnClick;
            btn.OnClick += logger.LogClick;
            btn.performclick(); 

        }

        private static void Sensor_SensorChanged(string arg1, double arg2)
        {
           Console.WriteLine(arg1 + " " + arg2);
        }
        public static double Calculate(Func<double, double, double> func)
        {
            Console.WriteLine("enter two number");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            return func(x, y);
        }
        public static void sendmessege()
        {
            Console.WriteLine("hello");
        }
        public static void sendEmail()
        {
            Console.WriteLine("send email to rawan@gmail.com");
        }
        public static List<int> Filter(int[] array, Predicate<int> predicate)
        {
            List<int> tem = new List<int>();
            foreach (int i in array)
            {
                if (predicate(i))
                    tem.Add(i);
            }
            return tem;
        }
        public static List<int> FilterArray(int[] array , IntFilter filter)
        {
            List<int> list = new List<int>();
            for(int i = 0; i < array.Length; i++)
            {
                if (filter(array[i]))
                {
                    list.Add(array[i]);
                }
            }
            return list;
        }
        public static void print(int x, Messege ms)
        {
            ms();
        }
        public static List< int> EvenNum(List<int> list)
        {
            return list.FindAll(n=>n%2==0);
        }
    }
}

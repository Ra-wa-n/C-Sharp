namespace lab4_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task2
            Counter c1 = new Counter(); 
            Counter c2 = new Counter(); 
            Counter c3 = new Counter();
            Console.WriteLine(Counter.counter);
            //task3
            Manager mgr = new Manager(101, "Ahmed", 8000, 2000, 5);
            mgr.DisplayInfo();          
            mgr.DisplayMangerInfo();    
            Developer dev = new Developer(102, "Sara", 7000, "C#", 3);
            dev.DisplayInfo();         
            dev.DisplayDevInfo(); 
            Intern intern = new Intern(103, "Ali", 2000, "Cairo University", 6);
            intern.DisplayInfo();       
            intern.DisplayInternInfo();
            //task4
            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle(5);
            shapes[1] = new Rectangle(4, 6);
            shapes[2] = new Triangle(3, 4, 5);
            foreach (Shape sh in shapes)
            {
              Console.WriteLine(  sh.CalcArea()); 
            }
            //task 5
            Animal d = new Dog();
            Animal c = new Cat();
            Animal b = new Bird();
            d.MakeSound(); 
            d.Move();
            c.MakeSound(); 
            c.Move();
            b.MakeSound(); 
            b.Move();
            d.Sleep();
            //task 6
           Car car = new Car();
            car.Move();
            Console.WriteLine("Car Speed: " + car.GetSpeed());
            car.Stop();
            Robot r = new Robot();
            r.Move();
            Console.WriteLine("Robot Speed: " + r.GetSpeed());
            Console.WriteLine("Battery: " + r.GetBatteryLevel());
            r.Charge();
            // task 7
            Student s = new Student();
            s.Name = "Rawan";
            s.Age = 23;
            Console.WriteLine(s.Name + " is " + s.Age + " years old.");
            //task8
            Account[] accounts = new Account[3];

            accounts[0] = new SavingsAccount(1,"Rawan", 1000,4, 5);
            accounts[1] = new CheckingAccount(2,"Ali", 500, 200);
            accounts[2] = new SavingsAccount(3,"Sara", 2000, 3, 500);

           Console.WriteLine(accounts[1].Deposit(500));
            accounts[0].Withdraw(300);
            accounts[1].Withdraw(600); 
            accounts[2].Withdraw(1800);

        }
    }
}

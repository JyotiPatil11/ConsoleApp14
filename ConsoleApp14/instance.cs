using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{

    class HDFC
    {
        int accid;
        string name;
        int bal;
        static float roi = 7.8f;
        // obkect reqyrie to csll instance method
        public void m1()
        {
            int a = 90;
        }
        // static doesnt require object
        // classname.m2();
        static void m2()
        {

        }
        static void Main(string[] args)
        {
            HDFC h1 = new HDFC();
            h1.m1();
            h1.accid = 900;
            HDFC.m2();
            Console.WriteLine("Hello");
            Console.WriteLine(HDFC.roi);

        }
    }

    class Moviee
    {
        string moviename;
        int rating;

        // set value to moviename
        public void setMoviename(string nm)
        {
            moviename = nm;
        }
        public string getmoveename()
        {
            return moviename;
        }
        public void setRating(int r)
        {
            rating = r;
        }
        public int getrating()
        {
            return rating;
        }
    }
    class Mtest
    {
        static void Main(string[] args)
        {
            Moviee m1 = new Moviee();
            m1.setMoviename("Ready");
            Console.WriteLine(m1.getmoveename());
        }
    }
    class Resturnt
    {
        string reastaruntname;
        string area;
        long mobileno;
        int rating;

        public void setreastaruntname(string nm)
        {
            reastaruntname = nm;
        }
        public string getreastaruntname()
        {
            return reastaruntname;
        }
        public string Area
        {
            set { this.Area = value; }
            get { return area; }
        }
        public long Mobileno
        {
            set { this.mobileno = value; }
            get { return mobileno; }
        }
        public int Rating
        {
            set { this.Rating = value; }
            get { return rating; }
        }
    }
    class Test22
    {
        static void Main(string[] args)
        {
            Resturnt r1 = new Resturnt();

            r1.setreastaruntname("jyoti");
            Console.WriteLine(r1.setreastaruntname);
            r1.Area = "pune";
            Console.WriteLine(r1.Area);
            r1.Mobileno = 9356584894;
            Console.WriteLine(r1.Mobileno);
            r1.Rating = 6;
            Console.WriteLine(r1.Rating);
        }
    }
    class pen
    {
        string penname;
        string brand;
        string color;
        int price;

        public pen()
        {

        }
        public pen(string pname)
        {
            penname = pname;
        }
        public pen(string pnm, string br, int pr)
        {
            penname = pnm;
            brand = br;
            price = pr;

        }
        public pen(string pnm, string br, string c, int pr)

        {
            penname = pnm;
            brand = br;
            price = pr;
            color = c;


        }
        static void Main(string[] args)
        {
            pen p1 = new pen();
            pen p2 = new pen("Trimax");
            pen p3 = new pen("cello,gelpen,80");
        }
    }
    class pencil
    {
        string pname;
        int cost;
        static int c;



        // static constructor automatically called only once
        //static

        static pencil()
        {
            c = 900;
            Console.WriteLine("in static constructor");



        }
        //instance to intialise instance variable
        public pencil()
        {

        }
        public pencil(string pname, int cost)
        {
            // automaticall
            // this--currently invoking object address
            this.pname = pname;
            this.cost = cost;
        }
        //this.in instance method
        public void m1()
        {
            Console.WriteLine(" in m1");
        }
        static void Main(string[] args)
        {
            pencil p1 = new pencil();

            pencil p2 = new pencil("Apsra", 90);
        }
    }
    class overload
    {
        static int max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;

        }
        static int max(int a, int b, int c)
        {
            if (a > b && a > c)
                return a;
            else if (b > a && b > c)
                return b;
            else
                return c;
        }
        static void Main(string[] args)
        {
            int m1 = max(89, 78);
            Console.WriteLine("max from 2 is:" + m1);
            int m2 = max(23, 56, 22);
            Console.WriteLine("max2:" + m2);
        }
    }
    class Time
    {
        int time;
        int second;
        int hour;
        int minit;

        public Time()
        {
            Console.WriteLine(" hello, we will constructor");  // constructor created
        }
        public int Hour
        {
            set { hour = value; }
            get { return hour; }
        }
        public int Minit
        {
            set { minit = value; }
            get { return minit; }
        }
        public int Second
        {
            set { second = value; }
            get { return second; }
        }

    }
    class Timec
    {
        static void Main(string[] args)
        {
            Time obj = new Time();
            Console.WriteLine("enter the hour");
            obj.Hour = int.Parse(Console.ReadLine());



            Console.WriteLine("enter the minit");
            obj.Minit = int.Parse(Console.ReadLine());



            Console.WriteLine("enter the second");
            obj.Second = int.Parse(Console.ReadLine());
            Console.WriteLine(+obj.Hour + ":" + obj.Minit + ":" + obj.Second + ":");
        }
    }
    class Rect
    {
        int length;
        int width;
        int area;
        int perimeter;

        public Rect()

        {
            Console.WriteLine(" hi, I am constructor");  // constructer created
        }
        // properties created 
        public int Length
        {
            set { Length = value; }
            get { return Length; }
        }

        public int Width
        {
            set { Width = value; }
            get { return Width; }
        }
        public int Area
        {
            set { Area = value; }
            get { return Area; }
        }
        public int Perimeter
        {
            set { Perimeter = value; }
            get { return Perimeter; }
        }





    }
    class Rectcall
    {
        static void Main(string[] args)
        {
            Rect r1 = new Rect();

            Console.WriteLine("enter the length");
            r1.Length = int.Parse(Console.ReadLine());


            Console.WriteLine("enter the width");
            r1.Width = int.Parse(Console.ReadLine());


            r1.Area = r1.Length * r1.Width;
            Console.WriteLine("Area of Rect is = " + r1.Area);


            r1.Perimeter = 2 * (r1.Length * r1.Width);
            Console.WriteLine("perimeter of Rect is = " + r1.Perimeter);


        }
    }
    class G
    {
        int a;
        static int b;
        public G()
        {
            Console.WriteLine("in default constructor");
            a = 100;
        }
        public int A
        {
            set { a = value; }
            get { return a; }
        }
        public int B
        {
            set { b = value; }
            get { return b; }


        }
        static void Main(string[] args)
        {
            G ob = new G();
            ob.A = 1;
            ob.B = 2;

            G ob1 = new G();
            ob1.A = 11;
            ob1.B = 22;


            Console.WriteLine(ob.A);
            Console.WriteLine(ob.B);
            Console.WriteLine(ob1.A);
            Console.WriteLine(ob1.B);
        }
    }
    class array
    {
        static void Main(string[] args)
        {
            string[] Employees = { "Rahul", "Nidhi", "Karan" };
            int[] GridRowsSize = { 10, 20, 50, 100 };
            Console.WriteLine("Test App");
            Console.ReadLine();

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            string[] Employes = { "Rahul", "Nidhi", "Kirn" };
            int[] GridRowsize = { 10, 20, 50, 100 };
            Console.WriteLine("Array");
            Console.WriteLine(Employes[0]);
            Console.WriteLine(Employes[1]);
            Console.WriteLine(Employes[2]);
            Console.ReadLine();



        } 
    }
    class program2
    {
        static void Main(string[] args)
        {
            string[]Employes= { "Rahul", "Nidhi", "Kirn" };
            int[] GridRowsize = { 10, 20, 50, 100 };
            for (int i=0;i<Employes.Length;i++)
            {
                Console.WriteLine(Employes[i]);
            }
            Console.ReadLine();
        }
    }
    class Test4
    {
        static void Main(string[] args)
        {
            string[] users = { "sumit", "Amit", "Jatin", "Baby" };
            for (int i =0;i< users.Length;i++)
            {
                Console.WriteLine(users[i]);
            }
            Array.Sort(users);
            Console.WriteLine("Ordered List Display");
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i]);
            }
            Array.Reverse(users);
            Console.WriteLine(" Desc Ordered List Display");
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i]);
            }
        }

        
    }
}

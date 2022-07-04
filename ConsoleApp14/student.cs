using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class student
    {
        //oops concept

        // instance variable
        string name;
        int percent;
        int passoutyear;
        string branch;
        string technicalskills;

        static void Main(string[] args)
        {
            //local
            int x = 90;

            student s1 = new student();
            s1.name = "Jyoti";
            s1.percent = 90;
            s1.passoutyear = 2021;
            s1.branch = "Computer";
            s1.technicalskills = "csharp";


            student s2 = new student();
            s2.name = "Jyoti";
            s2.percent = 90;
            s2.passoutyear = 2020;
            s2.branch = "IT";
            s2.technicalskills = "Java";


            Console.WriteLine("enter name,percent,passoutyear,branch,tech");
            student s3 = new student();
            s2.name = Console.ReadLine();
            s2.percent = int.Parse(Console.ReadLine());
            s2.passoutyear = int.Parse(Console.ReadLine());
            s2.branch = (Console.ReadLine());
            s2.technicalskills = (Console.ReadLine());

            Console.WriteLine(s2.name);
            Console.WriteLine(s2.percent);
            Console.WriteLine(s2.passoutyear);
            Console.WriteLine(s1.branch);
            Console.WriteLine(s1.name);

        }

    }
    class student3
    {
        // instance variable
        string name;
        int percent;
        int passoutyear;
        string branch;
        string technicalskills;

        public void accept()
        {
            Console.WriteLine("enter name,percent,passoutyear,branch,tech");

            name = Console.ReadLine();
            percent = int.Parse(Console.ReadLine());
            passoutyear = int.Parse(Console.ReadLine());
            branch= Console.ReadLine();
            technicalskills = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("percentage:" +percent);
            Console.WriteLine("passoutyear" +passoutyear);
            Console.WriteLine("branch:" +branch);
            Console.WriteLine("technicalskills:" +technicalskills);
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            student3 s1 = new student3();

            s1.accept();
            s1.display();

            student3 s2 = new student3();

            s2.accept();
            s2.display();

            // Datatype in c#
            // value based int,float,double,char,long
            // Reference array,string,custom datatype
        }
    }
   class calculator
    {
        int n1, n2;//instance vaiable;
        // void u are not going to return any value
        public void add()
        {
            int sum = n1 + n2;
            Console.WriteLine("sum=" + sum);
        }
        public int multi ()
        {
            int r = n1 * n2;

            return r;


        }
        public float divide()
        {
            int div = n1 / n2;
            return div;

        }
        public int subtraction()
        {
            int sub = n1 - n2;
            return sub;
        }
    }
    class T
    {
        static void Main(string[] args)
        {
            calculator a = new calculator();
            a.add();
            a.multi();
            a.subtraction();

            Console.WriteLine("multi=" + a.multi());
            Console.WriteLine("div=" + a.divide());
            Console.WriteLine("sub=" + a.subtraction());
        }
    }
    class DD
    {
        int a;

        // write a method to accept data
        // write a method name factorial which will return factorial of given 
        // write main method
        
       public void accept ()
        {
            Console.WriteLine("enter a number");
            a = int.Parse(Console.ReadLine());
        }
        public int fact()
        {
            int f = 1;
            for(int i=1;i<=a;i++)
            {
                f = f * i;

            }
            return f;
        }

    }
    class T2
    {
        static void Main(string[] args)
        {
            DD f1 = new DD();
            f1.accept();
            f1.fact();
        }
    }
    class Fp
    {
        int a;

        public void accept()
        {
            Console.WriteLine("enter a number");
            a = int.Parse(Console.ReadLine());
        }

        public int fact()
        {
            int f = 1;
            for (int i = 1; i <= a; i++)
            {
                f = f * i;

            }
            return f;
        }
        public bool iseven()
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }
        public bool isprime()
        {
            int c = 0;
            for (int i =2;i<=a/2;i++)
            {
                if (a%i==0)
                {
                    c++;
                    break;
                }
            }
            if (c == 0)
                return true;
            else
                return
                     false;

        }
        static void Main(string[] args)
        {
            Fp pb = new Fp();
            pb.accept();
            int ans = pb.fact();
            Console.WriteLine("Factorial=" + ans);
            bool b1 = pb.iseven();
            Console.WriteLine("prime=" + b1);
        }


    }


    /* create a class Account containing folloing methods -
     * insert() to insert account data
     * display() to display account information
     * deposite() to deposit amount
     * withdrow() to withdrow amount
     * check_ blance() to check blance*/

    class Account
    {
        string aname;
        int accno;
        string accounttype;
        int bal;

        public void insert()
        {
            Console.WriteLine("enter name , account no, account type,bal")
                aname = Console.ReadLine();
            accno = int.Parse(Console.ReadLine());
            accounttype = (Console.ReadLine());
            bal = int.Parse(Console.ReadLine());

        }
        public void display()
        {
            Console.WriteLine("customer name=" + name);
            Console.WriteLine("account no=" + accno);
            Console.WriteLine("account type =" + accounttype);
            Console.WriteLine("balance=" + bal);
        }
        public void withdrow()
        {
            Console.WriteLine("enter the amount to withdrow");
            int wamt = int.Parse(Console.ReadLine());
            if (wamt > bal)
            {
                Console.WriteLine("insufficient bal");
            }

            else
            {
                bal = bal - wamt;
                Console.WriteLine("withdrow succesful");
                Console.WriteLine(" After withdrow ");
                Console.WriteLine("the bal is " + bal);
            }

        }
        public int checkbal()
        {
            return bal;

        }

    }
    class Bank
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            a.insert();
            a.display();
            a.withdrow();

            int c = a.checkbal();
            Console.WriteLine("checkbal=" + c);
        }
    }
}

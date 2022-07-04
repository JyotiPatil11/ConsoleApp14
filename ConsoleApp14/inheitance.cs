using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class p
    {
        int id = 101;
        string nm = "om";

        public int Id { get => id; set => id = value; }
        public string NM { get => nm; set => nm = value; }


        public void m1()
        {
            Console.WriteLine("in present m1");
        }
    }
    class child : p
    {
        public void m2()
        {
            Console.WriteLine("in child m2");
        }
    }
    class Inherit
    {
        static void Main(string[] args)
        {
            child c = new child();
            c.m1();
            c.m2();
            Console.WriteLine(c.Id);
            Console.WriteLine(c.NM);
        }
    }
    class Gparent
    {
        // multilevel
        public string a = "jyoti";


        public void m1()
        {
            Console.WriteLine(" first child");
        }
    }
    class pparent : Gparent
    {
        public void m2()
        {
            Console.WriteLine("second child");
        }
    }
    class cchild : pparent
    {
        public void m3()
        {
            Console.WriteLine("third child");
        }
    }
    class multi
    {
        static void Main(string[] args)
        {
            Gparent gp = new Gparent();
            gp.m1();
            pparent p = new pparent();
            p.m1();
            p.m2();
            cchild cc = new cchild();
        }
    }
    class Teacher
    {
        string tname;

        int experience;
        public Teacher()
        {
            Console.WriteLine("in teacher constructor");

        }
        public Teacher(string tname, int experience)
        {
            this.tname = tname;

            this.Experience = Experience;
        }
        public string Tname { get => tname; set => tname = value; }
        public int Experience { get => Experience; set => Experience = value; }
    }
    // Relationship is
    class VisitingTeacher : Teacher
    {
        int hrs, rate;
        public VisitingTeacher(string nm, int exp, int hrs, int r) : base(nm, exp)
        {
            Console.WriteLine("in vistingteacher constructor");
            this.Hrs = hrs;
            this.Rate = r;

        }
        public int hrs { get => hrs; set => hrs = value; }
        public int rate { get => rate; set => rate=value; }

    }
    /* class permentTeacher : Teacher
     * {
     * 
      }
    */
    class TTT
    {
        static void Main(string[] args)
        {
            VistingTeacher v = new VisitingTeacher("jyoti", 40000, 15, 5, 1000);
        }
    }
    class PenA
    {
        string brand;
        int cost;
        string color;

        public PenA(string brand, int cost, string color)
        {
            this.Brand = brand;
            this.Cost = cost;
            this.Color = color;
        }

        public string Brand { get => brand; set => brand = value; }
        public int Cost { get => cost; set => cost = value; }
        public string Color { get => color; set => color = value; }
    }
    class CompassBox
    {
        string Compass_brand;
        int price;
        PenA Pen;

        static void Main(string[] args)
        {
            CompassBox box = new CompassBox();
            box.Compass_brand = "Apsara";
            box.price = 200;
            box.Pen = new PenA("cello",50,"blue");
        }
    }
    class parent
    {
        string name;
        public void play()
        {
            Console.WriteLine("play on ground");
        }
        public virtual void study()
        {
            Console.WriteLine("Read books");
        }
        // polymorphim - one name but multipal forms

        class child : parent
        {
            // method riding
            public override void study()
            {
                Console.WriteLine("learn watiching online videos");
            }

        }
        class TTtest
        {
            static void Main(string[] args)
            {
                parent p = new parent();
                p.study();
                child c1 = new child();
                //reference 
                parent p2 = new child();
                p2.study();
            }
        }
    }
    class parentp
    {
        string name;
        public void play()
        {
            Console.WriteLine("play on ground");
        }
        public virtual void study()
        {
            Console.WriteLine("read books");
        }
        // method hidding
        public static void m1()
        {
            Console.WriteLine("in parent");
        }
        class child : parentp
        {
            // method hiding
            public static void m1()
            {
                Console.WriteLine(" in child m1");
            }
            public new void play()
            {
                Console.WriteLine("play videos games");
            }
            public override void study()
            {
                Console.WriteLine("watching movies");

            }
            static void Main(int a)
            {

            }
            static void Main(string[] args)
            {
                Main(10);
                child.m1();
                parentp p = new child();
                p.play();
            }
        }

    }
    class ppppp
    {
        public virtual void m1()
        {
            Console.WriteLine("in parent m1");
        }
    }
    class cc1 : ppppp
    {
        public sealed override void m1()
        {
            Console.WriteLine("in child1 m1");
        }
        static void Main(string[] args)
        {
            ppppp ob = new cc1();
            ob.m1();
        }
    }
    class stud
    {
        int sid;
        string name;
        int percent;

        public stud(int sid, string name, int percent)
        {
            this.sid = sid;
            this.name = name;
            this.percent = percent;
        }
        public override string ToString()
        {
            return $"sid: {sid} Name:{name}percentage:{percent}";
        }
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);
            stud s1 = new stud(1, "omkar", 90);
            Console.WriteLine(s1);
            //console.WriteLine(s1.percent);//internally it tries to call tostring()
        }
    }
    abstract class Teacher3
    {
        string nmae;
        int exper;
        public Teacher3(string nmae,int exper)
        {
            this.nmae = nmae;
            this.exper = exper;
        }
        public Teacher3()
        {

        }
       
       

        public string Nmae { get => nmae; set => nmae= value; }
        public int Exper { get => exper; set => exper = value; }

        public void m3()
        {

        }
        abstract public void calculatesalary();

    }
    class permanetTeacher : Teacher3
    {
        int salary;
       public permanetTeacher():base()
        {

        }
        public override void calculatesalary()
        {
            Console.WriteLine("salary" + salary);
        }

    }
    class VisitingTeacher:Teacher3
    {
        int hrs, rate;
       public override void calculatesalary()
        {
            Console.WriteLine("Salary=" + hrs * rate);
        }
    }
    class callTeacher
    {
        static void Main(string[] args)
        {
            Teacher3 t = new permanetTeacher();
            p.calculatesalary();
        }
    }


}








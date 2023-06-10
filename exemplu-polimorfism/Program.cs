using Microsoft.VisualBasic.FileIO;

internal class Program
{
    public class FairyTale
    {
        public void Act0()
        {
            Console.WriteLine("0 Inceput poveste originala");
            Act1();
        }

        public virtual void Act1()
        {
            Console.WriteLine("1 Printesa intalneste broscoiul");
            Act2();
        }

        public void Act2()
        {
            Console.WriteLine("2 Printesa saruta broscoiul");
            Act3();
        }

        public virtual void Act3()
        {
            Console.WriteLine("3 Broscoiul se transforma in print");
            Act4();
        }

        public virtual void Act4()
        {
            Console.WriteLine("4 Si au trait multi ani fericiti");
            Act5();
        }

        public void Act5()
        {
            Console.WriteLine("5 Sfarsit fericit");
        }
    }
    
    public class UnhappyTale : FairyTale
    {
        public void Act0()
        {
            Console.WriteLine("0 Inceput poveste modificata");
            Act1();
        }

        public void Act2()
        {
            Console.WriteLine("2 Printesa atinge broscoiul");
            Act3();
        }

        public override void Act3()
        {
            Console.WriteLine("3 Broscoiul ramane broscoi");
            Act4();
        }

        public override void Act4()
        {
            Console.WriteLine("4 Printesa fuge ingrozita");
            Act5();
        }

        public void Act5()
        {
            Console.WriteLine("5 Sfarsit nu prea fericit");
        }
    }

    private static void Main(string[] args)
    {
        FairyTale tale;

        Console.WriteLine("FAIRY TALE");
        tale = new FairyTale();
        tale.Act0();
       

        Console.WriteLine("UNHAPPY TALE");
        tale = new UnhappyTale();
        tale.Act0();
    }
}
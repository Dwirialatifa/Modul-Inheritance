using System;
using System.Reflection.Metadata;

class Processor
{
   
    public string merk;
    public string tipe;

}

class Intel : Processor
{
    public Intel()
    {
        merk = "Intel";
    }
  
}

class AMD : Processor
{

    public AMD()
    {
        merk = "AMD";
    }
}

class Corei3 : Intel
{
    public Corei3()
    {
        tipe = "Corei3";
    }
}

class Corei5 : Intel
{
    public Corei5()
    {
        tipe = "Corei5";
    }
}

class Corei7 : Intel
{
    public Corei7()
    {
        tipe = "Corei7";
    }
}

class Ryzen : AMD
{
    public Ryzen()
    {
        tipe = "RAYZEN";
    }
}

class Athlon : AMD
{
    public Athlon()
    {
        tipe = "ATHLON";
    }
}

class Vga
{
    public string merk;
 
}

class Nvidia : Vga
{
    public Nvidia()
    {
        merk = "Nvidia";
    }

    class amd : Vga
    {
        public amd()
        {
            merk = "amd";
        }


        class Laptop
        {
            public string merk;
            public string tipe;
            public Vga vga;
            public Processor processor;

            public void LaptopDinyalakan()
            {
                Console.WriteLine("Laptop dengan merk " + merk + " bertipe " + tipe + " menyala ");
            }
            public void LaptopDimatikan()
            {
                Console.WriteLine("Laptop dengan merk " + merk + " bertipe " + tipe + " mati ");
            }
        }

        class ASUS : Laptop
        {
            public string tipe;
            public ASUS()
            {
                merk = "ASUS";
            }
        }

        class ROG : ASUS
        {
            public ROG()
            {
                tipe = "ROG";
            }
        }

        class Vivobook : ASUS
        {
            public Vivobook()
            {
                tipe = "Vivobook";
            }
            public void Ngoding()
            {
                Console.WriteLine("Ctak Ctak Ctak, error lagi!!");

            }
        }

        class ACER : Laptop
        {
            public string tipe;
            public ACER()
            {
                merk = "ACER";
            }
        }

        class Swift : ACER
        {
            public Swift()
            {
                tipe = "Swift";
            }
        }

        class Predator : ACER
        {
            public Predator()
            {
                tipe = "Predator";
            }
            public void BermainGame()
            {
                Console.WriteLine(" Laptop " + merk + " " + tipe + " sedang memainkan game ");
            }
        }
        class Lenovo : Laptop
        {
            public string tipe;
            public Lenovo()
            {
                merk = "Lenovo";
            }
        }

        class IdeaPad : Lenovo
        {
            public IdeaPad()
            {
                tipe = "IdeaPad";
            }
        }

        class Legion : Lenovo
        {
            public Legion()
            {
                tipe = "Legion";
            }
        }

        class Tugas
        {
            public static void Main(string[] args)
            {
                Laptop laptop1 = new Vivobook();
                laptop1.vga = new Nvidia();
                laptop1.processor = new Corei5();

                Console.WriteLine(laptop1.vga + " " + laptop1.processor.merk + " " + laptop1.processor.tipe);
                //laptop1.Ngoding();

                Laptop laptop2 = new IdeaPad();
                laptop2.vga = new amd();
                laptop2.processor = new Ryzen();
                //laptop2.LaptopDinyalakan();
                //laptop2.LaptopDimatikan();

                Predator predator = new Predator();
                predator.vga = new amd();
                predator.processor = new Corei7();
                //predator.BermainGame();
    

            }
        }
    }
}





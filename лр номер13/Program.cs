using System.Text;

namespace Printers

{
    internal class Program
    {
        public static List<Printer> printers;
        public static List<Cartridge> cartridges;

        static void Main(string[] args)
        {
            cartridges = new List<Cartridge>()
            {
                new Cartridge() { id = 0, Vendor = Printer.vendor.Hewlett_Packard, model = "CE310A", dateOfPurchase = 19102017, dateOfRefill = 19102017, pages = 1000 },
                new Cartridge() { id = 1, Vendor = Printer.vendor.Sonny, model = "CE310B", dateOfPurchase = 20102017, dateOfRefill = 19122017, pages = 835 },
                new Cartridge() { id = 2, Vendor = Printer.vendor.Samsung, model = "CE310C", dateOfPurchase = 19102017, dateOfRefill = 19102018, pages = 13 },
            };

            printers = new List<Printer>()
            {
                new Printer(0, Printer.vendor.Hewlett_Packard, Printer.type.LaserJet, "M111a", cartridges[0], 19102017, 10),
                new Printer(1, Printer.vendor.Sonny, Printer.type.Inkjet, "M111b", cartridges[1], 20102017, 5),
                new Printer(2, Printer.vendor.Samsung, Printer.type._3D, "M111c", cartridges[2], 19102017, 3),
            };

            Save();
            Load();

            Console.WriteLine("Выводим все принтеры:");
            foreach (Printer printer in printers)
                Console.WriteLine(printer.ToString());

            Console.WriteLine("Выводим все картриджи:");
            foreach (Cartridge cartridge in cartridges)
                Console.WriteLine(cartridge.ToString());

            Console.WriteLine("Печатаем по 20 страниц на каждом принтере:");
            foreach (Printer printer in printers)
                printer.Print(20);

            Console.WriteLine("Проверяем оригинальность картриджей:");
            foreach (Cartridge cartridge in cartridges)
                Console.WriteLine(cartridge.IsOriginal());

            Console.WriteLine("Использование операторов (-- и +) для первого принтера:");
            printers[0]--;
            Printer p = printers[0] + 5;
        }

        public static void Save()
        {
            string saveText = "";
            foreach (Printer printer in printers)
            {
                saveText += printer.id + ";" + (int)printer.Vendor + ";" + (int)printer.Type + ";" + printer.model + ";" + (printer.cartridge != null ? printer.cartridge.id : "-1") + ";" + printer.dateOfPurchase + ";" + printer.guarantee + "\n";
            }
            File.WriteAllText("prn.txt", saveText.Trim());

            saveText = "";
            foreach (Cartridge cartridge in cartridges)
            {
                saveText += cartridge.id + ";" + (int)cartridge.Vendor + ";" + cartridge.model + ";" + cartridge.dateOfPurchase + ";" + cartridge.dateOfRefill + ";" + cartridge.pages + "\n";
            }
            File.WriteAllText("crt.txt", saveText.Trim());
        }

        public static void Load()
        {
            string[] file = File.ReadAllText("crt.txt").Split('\n');
            cartridges = new List<Cartridge>();

            foreach (string line in file)
            {
                string[] parameters = line.Split(';');
                cartridges.Add(new Cartridge() { id = int.Parse(parameters[0]), Vendor = (Printer.vendor)int.Parse(parameters[1]), model = parameters[2], dateOfPurchase = long.Parse(parameters[3]), dateOfRefill = long.Parse(parameters[4]), pages = int.Parse(parameters[5]) });
            }

            file = File.ReadAllText("prn.txt").Split('\n');
            printers = new List<Printer>();

            foreach (string line in file)
            {
                string[] parameters = line.Split(';');
                Printer printer = new Printer(int.Parse(parameters[0]), (Printer.vendor)int.Parse(parameters[1]), (Printer.type)int.Parse(parameters[2]), parameters[3], cartridges.FirstOrDefault(c => c.id == int.Parse(parameters[4])), long.Parse(parameters[5]), byte.Parse(parameters[6]));
                printers.Add(printer);
                if (printer.cartridge != null)
                    printer.cartridge.printer = printer;
            }
        }
    }

    public class Printer
    {
        public enum vendor
        {
            Hewlett_Packard, Sonny, Samsung
        }
        public enum type
        {
            LaserJet, Inkjet, _3D
        }

        public int id;
        public vendor Vendor;
        public type Type;
        public string model;
        public Cartridge cartridge;
        public long dateOfPurchase;
        public byte guarantee;


        public Printer(int id, vendor Vendor, type Type, string model, Cartridge cartridge, long dateOfPurchase, byte guarantee)
        {
            this.id = id;
            this.Vendor = Vendor;
            this.Type = Type;
            this.model = model;
            this.cartridge = cartridge;
            this.dateOfPurchase = dateOfPurchase;
            this.guarantee = guarantee;
        }

        public void Print(int pages)
        {
            if (cartridge == null)
            {
                Console.WriteLine("Ошибка! Отсутствует картридж!");
                return;
            }
            if (cartridge.pages < pages)
            {
                Console.WriteLine("Ошибка! Недостаточно страниц!");
                return;
            }
            Console.WriteLine("Printed " + pages + " pages");
            cartridge.pages -= pages;
        }

        public int CountDaysUntillGuaranteeExpire()
        {
            return (int)(new DateTime((int)dateOfPurchase % 10000, (int)dateOfPurchase / 1000 % 100, (int)dateOfPurchase / 1000000) - DateTime.Today).TotalDays;
        }

        public bool CheckCartridge()
        {
            return cartridge != null;
        }

        public bool CheckNotEmptyCartridge()
        {
            if (cartridge == null)
                return false;
            return cartridge.pages > 0;
        }

        public static Printer operator ++(Printer p)
        {
            p.Print(1);
            return p;
        }

        public static Printer operator +(Printer p, int pages)
        {
            p.Print(pages);
            return p;
        }

        public static Printer operator --(Printer p)
        {
            p.cartridge = null;
            return p;
        }

        public static Printer operator !(Printer p)
        {
            p.cartridge = new Cartridge();
            return p;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Printer))
                return false;
            else
                return Vendor == ((Printer)obj).Vendor && Type == ((Printer)obj).Type;
        }

        public override string ToString()
        {
            return $"{id}. {Vendor} {Type} {model} ({dateOfPurchase / 1000000}.{dateOfPurchase / 1000 % 100}.{dateOfPurchase % 10000})";
        }

        public override int GetHashCode()
        {
            int hash = id;
            for (long i = dateOfPurchase; i > 0; i /= 10)
                hash += (int)i % 10;
            hash += (int)Type;
            hash += (int)Vendor;
            return hash;
        }
    }

    public class Cartridge
    {
        public int id;
        public Printer.vendor Vendor;
        public Printer printer;
        public string model;
        public long dateOfPurchase;
        public long dateOfRefill;
        public int pages;

        public int CountPages()
        {
            return pages;
        }

        public bool IsOriginal()
        {
            return printer.Vendor == Vendor && dateOfPurchase == dateOfRefill;
        }

        public static Cartridge operator !(Cartridge c)
        {
            c.pages = 0;
            return c;
        }

        public static Cartridge operator ~(Cartridge c)
        {
            c.pages = 200;
            c.dateOfRefill = DateTime.Today.Year + DateTime.Today.Month * 10000 + DateTime.Today.Day * 1000000;
            return c;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Cartridge))
                return false;
            else
                return Vendor == ((Cartridge)obj).Vendor;
        }

        public override string ToString()
        {
            return $"$$ {id}. {Vendor} {model} ({pages} стр.) [{dateOfPurchase / 1000000}.{dateOfPurchase / 1000 % 100}.{dateOfPurchase % 10000}] $$";
        }

        public override int GetHashCode()
        {
            int hash = pages;
            hash += id;
            foreach (char c in model)
            {
                hash += c;
            }
            return hash;
        }
    }
}
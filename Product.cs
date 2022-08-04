using System;
class Product
{
    private int id;
    private string name;
    private double price;
    public Product(int id, string name, double price)
    {
        this.id = id;
        this.name = name;
        this.price = price;
    }
    public override string ToString()
    {
        return String.Format("The id is {0} and "+name+" and price is {0}"
            , id, name, price);
    }

    class Laptop : Product
    {
        private string ram = "16GB";
        private string chip = "Apple M1"
        public static void Main(string[] args)
        {
            Console.WriteLine("New Laptop: ");
            Laptop laptop = new Laptop();
            laptop.id(6);
            laptop.name("Macbook");
            laptop.price(2.99);
            laptop.ram;
            laptop.chip;
            Console.WriteLine("New Laptop: ", laptop);
        }
    }

    class Book : Product
    {
        private string infor = "Truyen tranh";
        private string author = "Doremom"
        public static void Main(string[] args)
        {
            Console.WriteLine("New Book: ");
            Book book = new Book();
            book.id(6);
            book.name("Thu vien");
            book.price(2.99);
            book.infor;
            book.author;
            Console.WriteLine("New Book: ", book);
        }
    }
}


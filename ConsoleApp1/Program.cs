
using ConsoleApp1;
using System.Diagnostics;

Repostory<Book> obj = new();
Book books = new();
int choice;
while (true)
{
    Console.WriteLine("1-Yeni kitab eleve ele");
    Console.WriteLine("2-Kitablari goster");
    Console.WriteLine("3-Kitabi sil");
    Console.WriteLine("4-Idsine gore kitablarin melumatlarini ver");
    Console.WriteLine("5-Kitablari axtar");

    int.TryParse(Console.ReadLine(), out choice);

    switch (choice) 
    {
        case 1:
            Console.WriteLine("Kitabin adini daxil edin");
            books.Title = Console.ReadLine();
            Console.WriteLine("Yazicini daxil edin");
            books.Author = Console.ReadLine();
            Console.WriteLine("ID daxil edin");
            books.Id = int.Parse(Console.ReadLine());
            obj.Add(books);
            break;
        case 2:
            Console.WriteLine("butun kitablari goster ");
            obj.GetAll();
            foreach (Book book in obj.GetAll())
            {
                Console.WriteLine(book.Title);
                Console.WriteLine(book.Author);
            }
            break;
        case 3:
            Console.WriteLine("id sine gore kitabi sil");
            Console.WriteLine("idini daxil ele");
            var id= int.Parse(Console.ReadLine());
            foreach (Book book in obj.Delete(id))
            {
                Console.WriteLine(book);
            }
            break;
        case 4:
            Console.WriteLine("idini daxil ele ");
            int id2 = int.Parse(Console.ReadLine());
            if (id2 == null)
            {
                Console.WriteLine("kitab tapilmadi");
            }
            Console.WriteLine(books.Title);
            break; 
        case 5:
            Console.WriteLine("axtardigini kitabi daxil eliyin");
            var text= Console.ReadLine();
            var search = obj.Search(m => m.Title.Contains(text));
            foreach (var item in search)
            {
                Console.WriteLine($"{item.Title} {item.Author}");
            }
            break;
    
    }

}



using EntityFrameworkTests;

class Program
{
    static void Main()
    {
        using (ApplicationCotext db = new ApplicationCotext())
        {
            // создаем два объекта User
            Users tom = new Users { FirstName = "Tom", SecondName = "Smit", Age = 33 };
            Users alice = new Users { FirstName = "Alice", SecondName = "Golf", Age = 26 };

            // добавляем их в бд
            db.Users.Add(tom);
            db.Users.Add(alice);
            db.SaveChanges();
            Console.WriteLine("Объекты успешно сохранены");

            // получаем объекты из бд и выводим на консоль
            var users = db.Users.ToList();
            Console.WriteLine("Список объектов:");
            foreach (Users u in users)
            {
                Console.WriteLine($"{u.Id}.{u.FirstName} {u.SecondName} - {u.Age}");
            }
        }
    }
}
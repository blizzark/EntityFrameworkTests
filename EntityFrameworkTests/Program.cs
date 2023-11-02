

using EntityFrameworkTests;

class Program
{
    static void Main()
    {
        using (MyDbContext db = new MyDbContext())
        {
            var users = db.Users.ToList();



            db.SaveChanges();
            Console.WriteLine("Объекты успешно сохранены");

            // получаем объекты из бд и выводим на консоль

            Console.WriteLine("Список объектов:");
            foreach (User u in users)
            {
                Console.WriteLine($"{u.Id}.{u.FirstName} {u.SecondName} - {u.Age}");
            }
        }
    }
}
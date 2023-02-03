
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTo_DoList
{
    public class User
    {
        public string? Name { get; set; }
        public long ID { get; set; } = new Random().NextInt64();
        public string? Password { get; set; }
        public double Amount { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        public List<Book> UsersBooks { get; set; } = new List<Book>();
        public List<Book> Authors { get; set; } = new List<Book>();
        public User()
        {

        }
        public User(string? name, string? password, double amount)
        {
            Name = name;
            Password = password;
            Amount = amount;
        }
        public void ShowInformation()
        {
            Console.WriteLine(
                 $"Name: {Name}\n" +
                 $"ID: {ID}\n" +
                 $"Money: ${Amount} \n" +
                 $"Password: {Password} \n");
        }
        public void ShowAllBooksofAuthor()
        {
            int i = 1;
            foreach (var book in Authors)
            {
                Console.Write(i + ". ");
                Console.WriteLine(book.ToString());
                i++;
            }
        }
        public void PurchaseBook(User user, Book book)
        {
            Console.Clear();
            Console.WriteLine($"Are you are sure want to buy \"{book.Name}\" with {book.Price}?");
            Console.Write("To confirm purchase press 'y', in another case press anything: ");
            char choice = Convert.ToChar(Console.ReadLine()!);
            if(choice == 'y')
            {
                bool isMoneyEnough = HasUserEnoughMoney(user, book);
                if(isMoneyEnough)
                {
                    Console.WriteLine($"You bought this book: \n {book}");
                    user.Amount -= book.Price;
                    AddBook(book, user);
                    Console.WriteLine("Your balance is: " + user.Amount);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("You doesn't have enough money.");
                    Console.WriteLine();
                }
            }
        }
        public bool HasUserEnoughMoney(User user, Book book)
        {
            if(user.Amount >= book.Price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddBook(Book bookToAdd, User user)
        {
            user.UsersBooks.Add(bookToAdd);
        }
        public void ChangePassword(User user, string newPassword)
        {
            user.Password = newPassword;
        }
    }
}

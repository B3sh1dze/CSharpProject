using SimpleTo_DoList;
using System.Runtime.Intrinsics.X86;

class Program
{
    public static void ChooseBookToBuy(User author, User user)
    {
        Console.Clear();
        author.ShowAllBooksofAuthor();
        Console.WriteLine("Choose which book you want to buy: ");
        var bookChoice = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < author.Authors.Count; i++)
        {
            if (i + 1 == bookChoice)
            {
                Console.WriteLine("You selected: " + author.Authors[i].ToString());
                author.PurchaseBook(user, author.Authors[i]);
                break;
            }
            else if (bookChoice > author.Authors.Count)
            {
                Console.WriteLine("Wrong input. there is no book on this iterator.");
                break;
            }
        }
    }
    public static void BooksMenu(User user)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        var book1 = new Book("The Lord Of The Rings: Fellowship Of The Ring.", "J.R.R. Tolkien", 29.99);
        var book2 = new Book("The Lord Of The Rings: The Two Towers.", "J.R.R. Tolkien", 25.99);
        var book3 = new Book("The Lord Of The Rings: Return Of The King.", "J.R.R. Tolkien", 35.99);
        var book4 = new Book("1984", "George Orwell.", 19.99);
        var book5 = new Book("Fahrenheut 451.", "Ray Bradbury", 16.79);
        var book6 = new Book("The Man Who Laughs.", "Victor Hugo", 24.70);
        var book7 = new Book("Notre Dame De Paris.", "Victor Hugo", 40.10);
        var book8 = new Book("Harry Potter And Philosopher's Stone.", "J.K. Rowling", 25.39);
        var book9 = new Book("Harry Potter And Chamber of Secrets.", "J.K Rowling", 23.49);

        var Tolkien = new User();
        Tolkien.Authors.Add(book1);
        Tolkien.Authors.Add(book2);
        Tolkien.Authors.Add(book3);
        var Orwell = new User();
        Orwell.Authors.Add(book4);
        var Bradbury = new User();
        Bradbury.Authors.Add(book5);
        var Hugo = new User();
        Hugo.Authors.Add(book6);
        Hugo.Authors.Add(book7);
        var Rowling = new User();
        Rowling.Authors.Add(book8);
        Rowling.Authors.Add(book9);
        while (true)
        {
            Console.WriteLine("Choose the author you want.");
            Console.WriteLine("1 - J.R.R. Tolkien");
            Console.WriteLine("2 - George Orwell");
            Console.WriteLine("3 - Ray Bradbury");
            Console.WriteLine("4 - Victor Hugo");
            Console.WriteLine("5 - J.K. Rowling");
            Console.WriteLine("6 - Change password");
            Console.WriteLine("7 - quit");
            var choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                ChooseBookToBuy(Tolkien, user);
            }
            else if (choice == 2)
            {
                ChooseBookToBuy(Orwell, user);
            }
            else if (choice == 3)
            {
                ChooseBookToBuy(Bradbury, user);
            }
            else if (choice == 4)
            {
                ChooseBookToBuy(Hugo, user);
            }
            else if (choice == 5)
            {
                ChooseBookToBuy(Rowling, user);
            }
            else if(choice == 6)
            {
                Console.Write("Enter your new password: ");
                var newPassword = Console.ReadLine();
                user.ChangePassword(user, newPassword);
            }
            else if (choice == 7)
                break;
            else { Console.WriteLine("Wrong input"); }
        }
    }
    public static void Main(string[] args)
    {

        var users = new User();
        var user1 = new User("John", "qwer", 152.52);
        var user2 = new User("Jack", "1234", 165.40);
        users.Users.Add(user1);
        users.Users.Add(user2);
        Console.WriteLine("1 - Log In.");
        Console.WriteLine("2 - Register.");
        Console.WriteLine("3 - exit.");
        while (true)
        {
            Console.WriteLine("Press 3 to exit");
            var userChoice = Convert.ToInt32(Console.ReadLine());
            if (userChoice == 1)
            {
                //log in
                IsUserValid(users.Users);
                BooksMenu(users);
            }
            else if (userChoice == 2)
            {
                // register
                Console.Write("Please enter your name: ");
                var name = Console.ReadLine();
                Console.Write("enter your password: ");
                var password = Console.ReadLine();
                Console.Write("Enter your money amount: ");
                var money = Convert.ToInt32(Console.ReadLine());
                var newUser = new User(name, password, money);
                users.Users.Add(newUser);
                BooksMenu(newUser);

            }
            else if (userChoice == 3)
            {
                break;
            }
            else 
            {
                Console.WriteLine("Wrong input");
                continue;
            }
        }
    }
    public static void IsUserValid(List<User> users) 
    {
        Console.Write("Please enter your name: ");
        var name = Console.ReadLine();
        Console.Write("Enter your password: ");
        var password = Console.ReadLine();
        foreach (var user in users)
        {
            if (name == user.Name && password == user.Password)
            {
                Console.WriteLine("Welcome!");
                break;
            }
            else if(name != user.Name && password == user.Password || name == user.Name && password != user.Password)
            {
                Console.WriteLine("Login failed. Please try again.");
                break;
            }
        }
        
    }
}
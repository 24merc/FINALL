/*
* Program Name: Ebay of Dogs
* Programmer: Jonathon Mercado
* Date: 12/19/2022
*
* Description: This program allows a user, guest or admin to
* order a dog online. It does this by asking for the type of dog the 
* user wants and show the user what they have in stock. This code will 
* then ask for the users information like name age and address. After confirming 
* that this information is correct the code will confirm that the dog 
* is on the way.
*/





List<string> allDogs = new List<string>();
    List<string> otherInfo = new List<string>();
    List<int> otherInfoage = new List<int>();

    Console.WriteLine("Press 1 to login");
    Console.WriteLine("press 2 to create a new user");

    int selection = int.Parse(Console.ReadLine());

    if (selection == 1)
    {
        Login();
    }
    else if (selection == 2)
    {
        CreateUsers();
    }

    void Login()
    {
        Console.WriteLine("Login");
        Console.WriteLine("Username: ");
        string username = Console.ReadLine();
        Console.WriteLine("password: ");
        string password = Console.ReadLine();

        Console.WriteLine("Invaild Username or Password");
    }

    void postlogin()
    {
        Console.Clear();
        Console.WriteLine("Login successful!");
        Console.WriteLine("What is the name of your dog");
        string name = Console.ReadLine();
        allDogs.Add(name);

        Console.Clear();

        if (name != null)
        {
            Console.WriteLine("Your dogs name is " + name);
        }

        Console.WriteLine("What breed is your dog?");
        Console.WriteLine("We currently have these in stock, Husky, German Shepherd, Pitbull.");
        string breeds = Console.ReadLine();
        allDogs.Add(breeds);

        Console.Clear();

        if (breeds == "Husky" || breeds == "German Shepherd" || breeds == "Pitbull")
        {
            Console.WriteLine("you have chosen " + breeds);
        }
        else
        {

            Console.WriteLine("We do not have this type of dog in stock at the  moment");
            return;
        }

        if (breeds == "Husky")
        {
            Console.WriteLine("We have these color huskys");
            Console.WriteLine("Pure brown");
            Console.WriteLine("Pure white");
            Console.WriteLine("which would you like");
            string colorChoice = Console.ReadLine();
            allDogs.Add(colorChoice);
            if (colorChoice == "Pure brown")
            {
                Console.WriteLine("youve chosen Pure brown");

            }
            else if (colorChoice == "Pure white")
            {
                Console.WriteLine("youve chosen pure white");
            }
            else if (colorChoice != "Pure brown" || colorChoice != "Pure White")
            {
                Console.WriteLine("we do not have this color in stock.");
                return;
            }


        }
        if (breeds == "German Shepherd")
        {
            Console.WriteLine("We have these color German Shepherd");
            Console.WriteLine("Pure brown");
            Console.WriteLine("Pure white");
            Console.WriteLine("which would you like");
            string colorChoice = Console.ReadLine();
            allDogs.Add(colorChoice);
            if (colorChoice == "Pure brown")
            {
                Console.WriteLine("youve chosen Pure brown");

            }
            else if (colorChoice == "Pure white")
            {
                Console.WriteLine("youve chosen pure white");
            }
            else if (colorChoice != "Pure brown" || colorChoice != "Pure White")
            {
                Console.WriteLine("we do not have this color in stock.");
                return;
            }
        }
        if (breeds == "Pitbull")
        {
            Console.WriteLine("We have these color Pitbull");
            Console.WriteLine("Pure brown");
            Console.WriteLine("Pure white");
            string colorChoice = Console.ReadLine();
            allDogs.Add(colorChoice);
            if (colorChoice == "Pure brown")
            {
                Console.WriteLine("youve chosen Pure brown");
            }
            else if (colorChoice == "Pure white")
            {
                Console.WriteLine("youve chosen pure white");
            }
            else if (colorChoice != "Pure brown" || colorChoice != "Pure White")
            {
                Console.WriteLine("we do not have this color in stock.");
                return;
            }
        }

        Console.Clear();
        Console.WriteLine("What is your adress?");
        string adressOfUser = Console.ReadLine();
        otherInfo.Add(adressOfUser);

        Console.Clear();

        Console.Clear();
        Console.WriteLine("What is your name?");
        string nameOfUser = Console.ReadLine();
        otherInfo.Add(nameOfUser);

        Console.Clear();

        Console.Clear();
        Console.WriteLine("What is your age?");
        int ageOfUser = int.Parse(Console.ReadLine());
        otherInfoage.Add(ageOfUser);

        if (ageOfUser < 18)
        {
            Console.WriteLine("age must be 18 or older to order dog");
            return;
        }

        Console.WriteLine("Is this information correct");
        Console.WriteLine("");
        Console.WriteLine("your adress is " + adressOfUser + " Your Name is " + nameOfUser + " Your age is " + ageOfUser);
        Console.WriteLine("");
        Console.WriteLine("Your dogs name is " + name);
        Console.WriteLine("");
        Console.WriteLine("Your dogs breed is " + breeds);

        Console.WriteLine("yes or no?");
        string infoCorrect = Console.ReadLine();

        Console.WriteLine("");

        if (infoCorrect == "yes")
        {
            Console.WriteLine("Your dog is on it's way!");
        }
        else if (infoCorrect == "no")
        {
            Console.Clear();
            Console.WriteLine("Refresh page and start over you dissapointment.");
            return;
        }

    }




void CreateUsers()
    {

    List<User> users = new List<User>();
    List<Guest> guests = new List<Guest>();
    List<Admin> admins = new List<Admin>();


    Console.WriteLine("Enter a username: ");
        string un = Console.ReadLine();

        Console.WriteLine("Enter a Password: ");
        string pw = Console.ReadLine();

        Console.WriteLine("Press 1 for a User.");
        Console.WriteLine("Press 2 for a Guest User.");
        Console.WriteLine("Press 3 for an Admin User");
        int Selection = int.Parse(Console.ReadLine());

        Console.Clear();

        if (Selection == 1)
        {
            User user = new User(un, pw);
            users.Add(user);
            Console.WriteLine(un + "has been created as a User");
        }
        else if (Selection == 2)
        {
            Guest user = new Guest(un, pw);
            guests.Add(user);
            Console.WriteLine(un + "has been created as a Guest User");
        }
        else if (Selection == 3)
        {
            Admin user = new Admin(un, pw);
            admins.Add(user);
            Console.WriteLine(un + "has been created as a Admin User");
        }
        else
        {
            Console.WriteLine("Invaild selection. no user");
        }



        postlogin();

    }









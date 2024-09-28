//giovanni sinobolli
//200589722
//program created: 2024-09-27 / 3:54pm
//program finished: 2024-09-27 / 7:07pm

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables//
            bool backToMenu = false;

            //book 1//
            string title1 = "The Little Prince";
            string author1 = "Antoine de Saint-Exupéry";
            int publication1 = 1943;
            bool book1avaliable = true;
            string book1answer = "";

            //book 2//
            string title2 = "Harry Potter and the Sorcerer’s Stone";
            string author2 = "J.K. Rowling";
            int publication2 = 1997;
            bool book2avaliable = true;
            string book2answer = "";

            //book 3//
            string title3 = "The Alchemist";
            string author3 = "Paulo Coelho";
            int publication3 = 1988;
            bool book3avaliable = false;
            string book3answer = "";

            //book 4//
            string title4 = "The Posthumous Memoirs of Brás Cubas";
            string author4 = "Machado de Assis";
            int publication4 = 1997;
            bool book4avaliable = true;
            string book4answer = "";

            //book 5//
            string title5 = "The Prince";
            string author5 = "Niccolò Machiavelli";
            int publication5 = 1532;
            bool book5avaliable = false;
            string book5answer = "";

            while (!backToMenu) //backtomenu now is true because of !, and this while loop keeps the things printing until the user prompts "menu", then the condition is not met and it clears everything, going back to the main menu
            {
                Console.WriteLine();
                //printing the list of the five book options, concatenating the title string with the author string to show the books name and the author of the book.
                Console.WriteLine("Welcome To our Library!");
                Console.WriteLine("_____________________________________________");

                Console.WriteLine("Our  most popular books:");
                Console.WriteLine();

                Console.WriteLine($"1- '{title1}', {author1}");
                Console.WriteLine();

                Console.WriteLine($"2- '{title2}', {author2}");
                Console.WriteLine();

                Console.WriteLine($"3- '{title3}', {author3}");
                Console.WriteLine();

                Console.WriteLine($"4- '{title4}', {author4}");
                Console.WriteLine();

                Console.WriteLine($"5- '{title5}', {author5}");

                Console.WriteLine("_____________________________________________");
                Console.WriteLine();
                Console.WriteLine("Any of those books caught you attention? find more about them just writting the name below!");

                string bookselection = Console.ReadLine().ToLower();

                switch (bookselection)
                {

                    case "the little prince":

                        Console.WriteLine();
                        Console.WriteLine("Details:");
                        Console.WriteLine($"Title: {title1}");
                        Console.WriteLine($"Author: {author1}");
                        Console.WriteLine($"Publication Date: {publication1}");
                        //Console.WriteLine($"Status: {book1avaliable}");
                        if(book1avaliable == true) Console.WriteLine("Status: Avaliable"); //those "if"s are responsible for showing if the book is avaliable, if the bool is true prints that is avaliable, and if bool is false prints that is not avaliable.
                        else if(book1avaliable == false) Console.WriteLine("Status: Not Avaliable");

                        Console.WriteLine();

                        if (book1avaliable == true)
                            Console.WriteLine("Would You like to borrow it?: (To go back to the main page, write 'menu')");
                        else Console.WriteLine("This book is not avaliable, Write 'menu' to go back and seleck another book.");

                        book1answer = Console.ReadLine().ToLower();
                        switch (book1answer)
                        {
                            case "yes":
                                book1avaliable = false;
                                Console.WriteLine();
                                Console.WriteLine("Reservation made! Please come pick it up in the next 3 bussiness days.");
                                Console.WriteLine();
                            break;

                            case "menu":
                                Console.Clear();
                            continue; //this continue is REALLY IMPORTANT because, when the user writes "menu", it clears the console, and it goes back to the beggining of the loop, making the user go back to the "main page" of the program
                        }

                    break;

                    case "harry potter and the sorcerer's stone":

                        Console.WriteLine();
                        Console.WriteLine("Details:");
                        Console.WriteLine($"Title: {title2}");
                        Console.WriteLine($"Author: {author2}");
                        Console.WriteLine($"Publication Date: {publication2}");
                        //Console.WriteLine($"Status: {book2avaliable}");
                        if (book2avaliable == true) Console.WriteLine("Status: Avaliable"); //those "if"s are responsible for showing if the book is avaliable, if the bool is true prints that is avaliable, and if bool is false prints that is not avaliable.
                        else if (book2avaliable == false) Console.WriteLine("Status: Not Avaliable");
                        Console.WriteLine();

                        if (book2avaliable == true)
                            Console.WriteLine("Would You like to borrow it?: (To go back to the main page, write 'menu')");
                        else Console.WriteLine("This book is not avaliable, Write 'menu' to go back and seleck another book.");

                            book2answer = Console.ReadLine().ToLower();
                            switch (book2answer)
                            {
                                case "yes":
                                    book2avaliable = false;
                                    Console.WriteLine();
                                    Console.WriteLine("Reservation made! Please come pick it up in the next 3 bussiness days.");
                                    Console.WriteLine();
                                break;

                                case "menu":
                                    Console.Clear();
                                continue; //this continue is REALLY IMPORTANT because, when the user writes "menu", it clears the console, and it goes back to the beggining of the loop, making the user go back to the "main page" of the program
                            }

                    break;


                    case "the alchemist":

                        Console.WriteLine();
                        Console.WriteLine("Details:");
                        Console.WriteLine($"Title: {title3}");
                        Console.WriteLine($"Author: {author3}");
                        Console.WriteLine($"Publication Date: {publication3}");
                        //Console.WriteLine($"Status: {book3avaliable}");
                        if (book3avaliable == true) Console.WriteLine("Status: Avaliable"); //those "if"s are responsible for showing if the book is avaliable, if the bool is true prints that is avaliable, and if bool is false prints that is not avaliable.
                        else if (book3avaliable == false) Console.WriteLine("Status: Not Avaliable");
                        Console.WriteLine();

                        if (book3avaliable == true)
                            Console.WriteLine("Would You like to borrow it?: (To go back to the main page, write 'menu')");
                        else Console.WriteLine("This book is not avaliable, Write 'menu' to go back and seleck another book.");

                        book3answer = Console.ReadLine().ToLower();
                        switch (book3answer)
                        {
                            case "yes":
                                book3avaliable = false;
                                Console.WriteLine();
                                Console.WriteLine("Reservation made! Please come pick it up in the next 3 bussiness days.");
                                Console.WriteLine();
                                break;

                            case "menu":
                                Console.Clear();
                            continue; //this continue is REALLY IMPORTANT because, when the user writes "menu", it clears the console, and it goes back to the beggining of the loop, making the user go back to the "main page" of the program
                        }

                    break;


                    case "the posthumous memoirs of bras cubas":
                        Console.WriteLine();
                        Console.WriteLine("Details:");
                        Console.WriteLine($"Title: {title4}");
                        Console.WriteLine($"Author: {author4}");
                        Console.WriteLine($"Publication Date: {publication4}");
                        //Console.WriteLine($"Status: {book4avaliable}");
                        if (book4avaliable == true) Console.WriteLine("Status: Avaliable"); //those "if"s are responsible for showing if the book is avaliable, if the bool is true prints that is avaliable, and if bool is false prints that is not avaliable.
                        else if (book4avaliable == false) Console.WriteLine("Status: Not Avaliable");
                        Console.WriteLine();

                        if (book4avaliable == true)
                            Console.WriteLine("Would You like to borrow it?: (To go back to the main page, write 'menu')");
                        else Console.WriteLine("This book is not avaliable, Write 'menu' to go back and seleck another book.");

                        book4answer = Console.ReadLine().ToLower();
                        switch (book4answer)
                        {
                            case "yes":
                                book4avaliable = false;
                                Console.WriteLine();
                                Console.WriteLine("Reservation made! Please come pick it up in the next 3 bussiness days.");
                                Console.WriteLine();
                            break;

                            case "menu":
                                Console.Clear();
                            continue; //this continue is REALLY IMPORTANT because, when the user writes "menu", it clears the console, and it goes back to the beggining of the loop, making the user go back to the "main page" of the program
                        }

                    break;


                    case "the prince":

                        Console.WriteLine();
                        Console.WriteLine("Details:");
                        Console.WriteLine($"Title: {title5}");
                        Console.WriteLine($"Author: {author5}");
                        Console.WriteLine($"Publication Date: {publication5}");
                        //Console.WriteLine($"Status: {book5avaliable}");
                        if (book5avaliable == true) Console.WriteLine("Status: Avaliable"); //those "if"s are responsible for showing if the book is avaliable, if the bool is true prints that is avaliable, and if bool is false prints that is not avaliable.
                        else if (book5avaliable == false) Console.WriteLine("Status: Not Avaliable");
                        Console.WriteLine();

                        if (book5avaliable == true)
                            Console.WriteLine("Would You like to borrow it?: (To go back to the main page, write 'menu')");
                        else Console.WriteLine("This book is not avaliable, Write 'menu' to go back and seleck another book.");

                        book5answer = Console.ReadLine().ToLower();
                        switch (book4answer)
                        {
                            case "yes":
                                book5avaliable = false;
                                Console.WriteLine();
                                Console.WriteLine("Reservation made! Please come pick it up in the next 3 bussiness days.");
                                Console.WriteLine();
                                break;

                            case "menu":
                                Console.Clear();
                            continue; //this continue is REALLY IMPORTANT because, when the user writes "menu", it clears the console, and it goes back to the beggining of the loop, making the user go back to the "main page" of the program
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid command");
                    break;
                }
            }
        }
    }
}

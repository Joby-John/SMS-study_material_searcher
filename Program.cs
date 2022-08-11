// Trying to create a study material finder that helps in finding study material according to requirement
// no idea how im gonna do it anyways just starting , will find way on the way

//functions to implement 1. serachcond, main, textbooks as of now 
using System.Text.RegularExpressions;

SearchCond(); //calls the searchcond function 
static void SearchCond() // includes search conditions selects subjects
{
    Console.Write("Specifically looking for a subject ? Y/N: ");
    string Std = Console.ReadLine();
    if (Std == "Y")
        {
        Console.Write("Enter The Subject:  \n");
        Console.Write("Physics,Chemistry,Biology,Maths,Social: ");
        string sub = Console.ReadLine().ToLower();
        if (sub == "physics")
        {
            Physics();
        }
        else  if (sub == "chemistry")
        {
            Chemistry();
        }
        else if (sub == "biology")
        {
            Biology();
        }
        else if (sub == "maths")
        {
            Maths();
        }
        else if (sub == "social")
        {
            Social();
        }
        else
        {
            Console.Write("Enter a valid option");
        }

    }

    

}

// asks for the term to search for the selected subjects

static void Physics()
{
    Console.WriteLine("Enter the term you are searching for: ");
    string Term = Console.ReadLine();
    printresult("physics", Term);
}

static void Biology()
{
    Console.WriteLine("Enter the term you are searching for: ");
    string Term = Console.ReadLine();
    printresult("biology", Term);
}

static void Chemistry()
{
    Console.WriteLine("Enter the term you are searching for: ");
    string Term = Console.ReadLine();
    printresult("chemistry", Term);
}

static void Maths()
{
    Console.WriteLine("Enter the term you are searching for: ");
    string Term = Console.ReadLine();
    printresult("maths", Term);
}

static void Social()
{
    Console.WriteLine("Enter the term you are searching for: ");
    string Term = Console.ReadLine();
    printresult("social", Term);
}

static void printresult( string subject, string Term)
    {
    // function to search on the textbooks in textbook list based on parameters subject and term and return the results
    string Result = Textbook( subject , Term);
    Console.WriteLine(Result);//prints the result
    if (Result == null)
    {
        Console.WriteLine("\n\nFor term :" + Term + ", in subject : " + subject + " search unsuccessfull");
    }
    else
    {
        Console.WriteLine("\n\nFor term :" + Term + ", in subject : " + subject + " search successfull");
    }
}

static string Textbook (string subject, string term)
{
    string result = ("Not Found ");
    switch (subject)
    {
        case "physics" :
            Console.WriteLine("physics");
            break;
        case "chemistry":
            Console.WriteLine("chemistry");
            break;
        case "biology":
            Console.WriteLine("biology");
            break;
        case "maths":
            Console.WriteLine("chemistry");
            break;
        case "social":
             string path = @"C:\Users\Tony Stark\source\repos\SMS-study_material_searcher\chapterfiles\1.txt"; 
             string text = File.ReadAllText(path);
            text = text.ToLower();
            int firstloc = text.IndexOf(term);//finds index of first occurance of the term
            if (firstloc == -1)
            {
                result = ("Term not Found");
            }
            else
            {
                //using regex to find the indexes is a ba didea instead using for count
                var matches = Regex.Matches(text, term);
                Console.WriteLine("\n{0} occurances\n", matches.Count);


                //using while loop to find all the occurances
                int loc = firstloc;
                int n = 1;
                int limit =loc + 150;
                int last = text.LastIndexOf(".");
                while (loc <= text.LastIndexOf(term))
                {
                    Console.WriteLine( "\n{0}last location\n",text.LastIndexOf(term));
                    if (loc != -1 && (limit) <= last)
                    {
                        Console.WriteLine("limit : " + limit);

                        result = text.Substring(loc, limit);
                        
                        Console.WriteLine("\n{0} occurance \n\n",n);
                        Console.WriteLine(result);
                        text = text.Substring(limit);
                        loc = text.IndexOf(term);
                        limit = loc + 150;

                        n++;
                    }
                    else
                    {
                        Console.WriteLine("\nout of bounds");
                        break;
                    }
                }
                

                
                Console.WriteLine(n + " Term Found " );
                //result = text.Substring(firstloc, firstloc + 600);//passes a string of 600 indexes to result  
            }
            Console.WriteLine("social");
            break;
        default:
            Console.WriteLine(result);
            break;
    }
    string Result = ("success");
    return Result;
}
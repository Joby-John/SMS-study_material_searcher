// Trying to create a study material finder that helps in finding study material according to requirement
// no idea how im gonna do it anyways just starting , will find way on the way

//functions to implement 1. serachcond, main, textbooks as of now 
using System.Text.RegularExpressions;

SearchCond(); //calls the searchcond function 
static void SearchCond() // includes search conditions selects subjects
{
    
        Console.Write("Enter The Subject:  \n");
        Console.Write("Physics,Chemistry,Biology,Maths,Social: ");
        string sub = Console.ReadLine().ToLower();
        Console.WriteLine("Enter the term to search : ");
        string term = Console.ReadLine().ToLower();
        switch (sub)
        {
        case "physics":
            //Physics();
            break;

        case "chemistry":
            //Chemistry();
            break;
        case "biology":
            //Biology();
            break;
        case "maths":
            //Maths();
            break;
        case "social":
            Social(term);
            break;
        default:
            Console.Write("Enter a valid subject");
            break;
        }
}

// asks for the term to search for the selected subjects



static void Social(string term)
{
    string path = @"C:\Users\Tony Stark\source\repos\SMS-study_material_searcher\chapterfiles\1.txt";
    string text = File.ReadAllText(path);
    text = text.ToLower();
    int firstloc = text.IndexOf(term);//finds index of first occurance of the term
    //int limit = firstloc + 100;
    int last = text.LastIndexOf(term);
    Console.WriteLine("The first term is at : {0}", firstloc);
    if(firstloc == -1)
    {
        Console.WriteLine("NOT FOUND");
    }
    else
    {
        Console.WriteLine("Search results are printed below\n");
        while (firstloc != -1)
        {
            
            try
            {
                Console.WriteLine("FIRST TERM OF THIS PRINT: {0}", firstloc);
                Console.WriteLine("* {0}\n", text.Substring(firstloc, 250));//250 is the length of the string
                text = text.Substring(250);//here it is cut from the index of 251 as the part before that was printed in the last exceution
                firstloc = text.IndexOf(term);
                last = text.LastIndexOf(term);
                //limit = firstloc + 100;
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("EXCEPTION STARTED");
                Console.WriteLine("* {0}\n", text.Substring(firstloc));
                break;
            }
        }
    }
}


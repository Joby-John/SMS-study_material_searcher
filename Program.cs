// Trying to create a study material finder that helps in finding study material according to requirement
// no idea how im gonna do it anyways just starting , will find way on the way

//functions to implement 1. serachcond, main, weblist as of now 

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
    // function to search on the websites in website list based on parameters subject and term and return the results
    //string Result = Websites( subject , term);
    //Console.WriteLine(Result);//prints the result
    Console.WriteLine("For term :" + Term + ", in subject : " + subject + " nothing found");
}

//static string Websites(string subject, string term)
//{
//searches somehow in websites and returns
// Return result;
//}
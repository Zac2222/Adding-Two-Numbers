int num1;
int num2;
bool runAgain = true;
while (runAgain == true)
{
    string choice = "";
    Console.WriteLine("Please enter two numbers and the program will add them together");
    num1 = Convert.ToInt32(Console.ReadLine());
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

    Console.WriteLine("run again? (y / n)");

    while(choice != "yes" & choice != "y" & choice != "no" & choice != "n")
    {
        choice = Console.ReadLine().ToLower();
    }
    
    if(choice == "y" || choice == "yes")
    {
        runAgain = true;
    }
    else if(choice == "n" || choice == "no")
    {
        runAgain = false;
        Console.WriteLine("Now exiting");
    }
}




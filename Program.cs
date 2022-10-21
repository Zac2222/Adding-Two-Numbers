//Peer reviewed Valerie Aguilar
//Comment: runs great! :)

int num1;
int num2;
bool runAgain = true;
while (runAgain == true)
{
    bool isNumber;
    string choice = "";
    Console.WriteLine("Please enter two numbers and the program will add them together");
    do
    {
        isNumber = int.TryParse(Console.ReadLine(), out num1);
        if(isNumber == false)
        {
            Console.WriteLine("Please enter a valid number");
        }
    }while(isNumber == false);

    do
    {
     isNumber = int.TryParse(Console.ReadLine(), out num2);
        if(isNumber == false)
        {
            Console.WriteLine("Please enter a valid number");
        }
    }while(isNumber == false);

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




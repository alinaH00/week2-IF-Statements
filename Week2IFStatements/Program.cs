//Week 2
//Check Name
Console.WriteLine("Please Enter your last name:");
string userName = Console.ReadLine(); //Input

//Check gender
Console.WriteLine("Enter your gender (f/m/n");
//Use as less storage area as posible- strings are big, char is only 1 letter
//String ( stored in a heap)
//Char (stored in a stack)

char userGender = char.Parse(Console.ReadLine());

string greeting;

if(userGender == 'f')
{
    greeting = "Ms.";
 }
else if (userGender == 'm')
{
    greeting = "Mr.";
}
else
{
    greeting = "";
}


Console.WriteLine($"Hello, {greeting} {userName}!"); //Output



//Check Age
Console.WriteLine("Enter your year of birth:");

int userYB = Int32.Parse(Console.ReadLine());
int currentYear = DateTime.Now.Year;
int userAge = currentYear - userYB;


//Console.WriteLine("Enter your age:");
//int userAge = Int32.Parse(Console.ReadLine());

if (userAge >= 13)
{
    Console.WriteLine($"You are {userAge} - old enough to have an account");
}
else
{
    Console.WriteLine($"You are {userAge} - not old enough to have an account");
}



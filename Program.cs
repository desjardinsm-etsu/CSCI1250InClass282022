

/* What I write inbetween will not be executed by the compiler
or the interpeter.
 

 We want to make a text based type of game.

 1. Display a main menu!
 2. New Game
    -display "We wake up!"
    
    -ask questions? (Character Creation)
        -Race {Ogre, Elf, Human}
        -Class {Warrior, Rogue, Trashman}
            -Weapon
        -Gender
        -Height
        -Name
    
    -TBC Decisions of what to do after this...
        



// What is in the main menu?
-z. New Game
a. Load Game -> Wait till later when we do File in and Out
b. Settings -> Wait another week for this one.
    -difficulty
    -sound?
    -resolution
    -text speed
c. Credits
d. Quit






*/

//sajhfkljhdsakj
//Console.WriteLine();

//Console.BackgroundColor = ConsoleColor.Yellow;
//Console.ForegroundColor = ConsoleColor.DarkBlue;
//System.Console.WriteLine("To display to the screen");
//Console.WriteLine(1); //This is the same as above.

//display your menu process.


    System.Console.Write(   "1 - New Game\n" +
                            "2 - Load Game\n" +
                            "3 - Settings\n" +
                            "4 - Credits\n" +
                            "5 - Quit\n");
    


//New Game Option
//System.Console.WriteLine("<... we wake up ?!?!?...>");

int height;
System.Console.Write("\nEnter your height in inches! ");
height = Convert.ToInt32(Console.ReadLine()); //60
//What if they enter 1 inch?
//what if they enter - inches???

/*
string firstName;
string lastName;
string camelCasingForVariables;

string name = "Mathew";

int height2 = 45;

System.Console.WriteLine($"You entered {height + 5} inches on this date: {DateTime.Now}!");

bool trueOrFalse = true;
bool falseOrTrue = false;

byte evenSmaller = 255;
short smallerNumber = 256;
int number = 6;
long biggerNumber = 1000000000;

char character = 'a';

float anotherFloatingPoint = 56.58F;

double floatingPoint = 56.58;

decimal anotherAnotherFloatingPoint = 4568.45M;

character = 'b';
character = (char)(66 + 32);

bool something = true;

int sum = 4 + 5;

int remainder = 83 % 2;*/

//System.Console.WriteLine(Math.Exp(3E3));

/*
System.Console.WriteLine(Math.Max(2,3));
for(int i = 0; i < 8; i++)
{
    Console.WriteLine(Math.Pow(2,i));
}
*/

//System.Console.WriteLine(character);


int x = 6;
//12
x = x + 6;
//x is 12 here!

int y = 6;
y += 6;

int z = 5;
z -= 3; //z = z - 3

const double PI = 3.14159;
const double TAX_RATE = 0.095;


string myName = "Matt";
string myName2 = "Matt";

string capitalMyName = myName.ToUpper();


System.Console.Write("What is your name? ");

string myName3 = Console.ReadLine();

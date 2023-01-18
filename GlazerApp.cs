/* This is my code along as I read the book 
"C# Programming Yellow Book" by Rob Miles
In this app, I will be using the Glazer Calculator Exercise.
*/
namespace GlazerApp;
class Program
{
    static void Main(string[] args)
    {
        // set variables 
        double width, height, woodLength, glassArea;

        const double MAX_WIDTH = 5.0;
        const double MIN_WIDTH = 0.5;
        const double MAX_HEIGHT = 3.0;
        const double MIN_HEIGHT = 0.75;

        string widthString, heightString;

        //prompt a width in meters from user
        do
        {
            Console.WriteLine("Please enter the width of your window between " + MIN_WIDTH + " and " + MAX_WIDTH + " in meters: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
        } while (width < MIN_WIDTH || width > MAX_WIDTH); //make sure to set limits
        

        //prompt a height in meters from the user
        do
        {
            Console.WriteLine("Please enter the height of your window between " + MIN_HEIGHT + " and " + MAX_HEIGHT + " in meters: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
        } while (height < MIN_HEIGHT || height > MAX_HEIGHT); //make sure to set limits
        
        //obtain the length of the wood in feet
        woodLength = 2 * (width + height) * 3.25;

        //obtain the area of glass needed in meters
        glassArea = 2 * (width * height);

        //write the output for both wood length and glass area
        Console.WriteLine( "The length of the wood is " + woodLength + " feet" );
        Console.WriteLine( "The area of the glass is " + glassArea + " square meters" );

    }
}

//set up
Single Multiply = 0;
int height = 0;
int width = 0;
int rectangle1 = 0;
int rectangle2 = 0;

//input
Console.WriteLine("What is the height of the first rectangle?");
rectangle1 = int.Parse(Console.ReadLine());

Console.WriteLine("What is the width of the first rectangle?");
rectangle1 = int.Parse(Console.ReadLine());

//

Console.WriteLine("What is the height of the second rectangle?");
rectangle2 = int.Parse(Console.ReadLine());

Console.WriteLine("What is the width of the second rectangle?");
rectangle2 = int.Parse(Console.ReadLine());


//process
Multiply = height* width;


//output
if (rectangle1 > rectangle2) 
{
  Console.WriteLine("rectangle 1" + " is greater than " + "rectangle 2");
}
else if (rectangle1 == rectangle2)
{
  Console.WriteLine("rectangle 1" + " is equal to " + "rectangle 2");
}
else 
{
  Console.WriteLine("rectanlge 2" + " is greater than " + "rectangle 1");
}

Console.ReadLine();
            
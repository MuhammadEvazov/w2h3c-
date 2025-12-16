using Task2;


System.Console.Write($"Enter the radius of the circle: ");
double radius = Convert.ToDouble(Console.ReadLine());

Circle circle1 = new Circle(radius);

System.Console.WriteLine($"The Area of the circle is {circle1.GetArea()};");
System.Console.WriteLine($"The Diameter of the circle is {circle1.GetDiameter()};");
System.Console.WriteLine($"The Circumference of the circle is {circle1.GetCircumference()};");
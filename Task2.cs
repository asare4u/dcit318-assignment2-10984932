//Implementing Task 2 - Abstract Classes and Methods
public class Task2 {
  public static void Execute() {
    Circle circle = new Circle(7);
    Rectangle rectangle = new Rectangle(4, 5);

    Console.WriteLine($"Area of the circle: {circle.GetArea()}"); // Output: Area of the circle: 153.93804002589985
    Console.WriteLine($"Area of the rectangle: {rectangle.GetArea()}"); // Output: Area of the rectangle: 20
  }
}

//Defining the abstract class 'Shape'
public abstract class Shape {
  public abstract double GetArea();
}

//Defining the derived class 'Circle'
public class Circle : Shape {
  public double Radius { get; set; }

  public Circle(double radius) {
    Radius = radius;
  }

  public override double GetArea() {
    return Math.PI * Radius * Radius;
  }
}

//Defining the derived class 'Rectangle'
public class Rectangle : Shape {
  public double Length { get; set; }
  public double Width { get; set; }

  public Rectangle(double length, double width) {
    Length = length;
    Width = width;
  }

  public override double GetArea() {
    return Length * Width;
  }
}


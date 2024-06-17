//Implementing Task 3 - Interfaces
public class Task3 {
  public static void Execute() {
      Car car = new Car();
      Bicycle bicycle = new Bicycle();

      car.Move();      // Output: Car is moving
      bicycle.Move();  // Output: Bicycle is moving
  }
}

// Defining the interface 'IMovable'
public interface IMovable {
  void Move();
}

// Defining the class 'Car' that implements the 'IMovable' interface
public class Car : IMovable {
  public void Move() {
    Console.WriteLine("Car is moving");
  }
}

// Defining the class 'Bicycle' that implements the 'IMovable' interface
public class Bicycle : IMovable {
  public void Move() {
    Console.WriteLine("Bicycle is moving");
  }
}

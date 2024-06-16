//Implementing Task 1 - Inheritance and Method Overriding
//Defining the base class 'Animal'
public class Animal {
  public virtual void MakeSound() {
    Console.WriteLine("Some generic sound");
  }
}

//Defining the derived class 'Dog'
public class Dog : Animal {
  public override void MakeSound() {
    Console.WriteLine("Bark");
  }
}

//Defining the derived class 'Cat'
public class Cat : Animal {
  public override void MakeSound() {
    Console.WriteLine("Meow");
  }
}

//Implementing the 'Main' method
class Program {
  static void Main(string[] args) {
    Animal animal = new Animal();
    Dog dog = new Dog();
    Cat cat = new Cat();

    animal.MakeSound(); // Output: Some generic sound
    dog.MakeSound(); // Output: Bark
    cat.MakeSound(); // Output: Meow
  }
}
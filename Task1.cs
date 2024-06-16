//Implementing Task 1 - Inheritance and Method Overriding
public class Task1 {
  public static void Execute() {
    Animal animal = new Animal();
    Dog dog = new Dog();
    Cat cat = new Cat();

    animal.MakeSound(); // Output: Some generic sound
    dog.MakeSound(); // Output: Bark
    cat.MakeSound(); // Output: Meow
  }
}

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

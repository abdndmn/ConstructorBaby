# Baby Class with Constructors

This project demonstrates the usage of **constructors** in C#. It includes a `Baby` class with two constructors: a default constructor and a parameterized constructor. The program initializes and displays information about baby objects created using both constructors.

## Files

### `Baby.cs`
Defines the `Baby` class, which includes:

- **Properties**:
  - `DateTime BirthDate`: Stores the birth date of the baby.
  - `string Name`: Stores the first name of the baby.
  - `string Surname`: Stores the last name of the baby.

- **Constructors**:
  1. **Default Constructor**:
     - Prints "Ingaaaa" to the console.
     - Sets `BirthDate` to the current date and time.
  2. **Parameterized Constructor**:
     - Takes `name` and `surname` as parameters.
     - Prints "Ingaaaa" to the console.
     - Sets `BirthDate` to the current date and time.

### `Program.cs`
Contains the main program logic, which:

1. Creates a `Baby` object (`baby1`) using the default constructor.
   - Sets the properties `Name`, `Surname`, and `BirthDate` manually.
   - Prints the baby’s details to the console.

2. Creates a `Baby` object (`baby2`) using the parameterized constructor.
   - Prints the baby’s details to the console.

## Usage

1. **Clone or Download** the repository.
2. Open the project in an IDE like Visual Studio.
3. Run the `Program.cs` file.

## Output

When the program runs, the output will resemble:

```
Ingaaaa

First Baby:
Name: John
Surname: Doe
Birth Date: 12/21/2024 12:34:56 PM

Ingaaaa

First Baby:
Name: Ebubekir
Surname: Sıddık
Birth Date: 12/21/2024 12:34:57 PM
```

## Key Features

- Demonstrates the usage of both default and parameterized constructors.
- Provides an example of setting object properties manually and through constructors.

## Concepts Covered

- Constructors in C#.
- Object Initialization.
- Console Output.

---


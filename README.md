<img src="csharp.webp" alt="C-Sharp orgramming language logo" width=80 height="80">

# cse210-ww-student-template

This is the starter code for students in the worldwide content version of CSE 210.

This repository contains the starter code for many different projects. They are arranged as follows:

- `sandbox` - An empty project that you can use to play around with any concepts you like.
- `csharp-prep` - Starter projects for each of the C# Prep assignments.
- `prepare` - Starter projects for each of the preparation Learning Activities.
- `prove` - Starter projects for each of the prove Developer projects.
- `final` - Starter projects for final project.

---

This course is a 14 weeks semester course crunched to 7 weeks. This means every week, it's double the workload. Some programming languages are multi-paradigm, this means you can write your codes/programs in a Procedual way (line by line), Functional way (with functions), or with Objects (Classes/OOP). C# focuses more on Object Oriented Programming - OOP. And this course introduces the notion of classes and objects. Presenting the four core mechanics/principles of OOP - Abstraction, Encapsulation, Inheritance, and Polymorphism.

---

The course is structured this way - per week ↓  
| Learning Activity 🎯| Teach One Another 👨🏾‍🏫| Team Design 👨🏾‍🎨| Prove/Develop 👨🏾‍💻|
| :--------: | :--------: | :--------: | :--------: |

---

#### The course outcome is as follows:

- `Articulate` the principles of programming with classes.
- `Design` software using these principles of programming with classes.
- `Develop` working software using the techniques of programming with classes.

---

### Week-01:

Week1 is all about setting up our developer environment installing the needed software and tools. The lessons and activities introduce us to syntax of C# programming language. Since the previous semester was programming with functions in Python, similarities and difference were made with Python. For example, the way variables are declared/defined, functions, lists etc. These difference were taught in a pragmatic way with learning activities, to prep us.  
Example code snippets:

```c#
    Console.Write("Enter the your grade (please omit the '%' sign ): ");
        string theGrade = Console.ReadLine();

        if (int.TryParse(theGrade, out int studentGrade))
        {
            string letterGrade = "";
            char plusOrMinus = studentGrade % 10 >= 7 ? '+' : '-';

            if (studentGrade >= 90)
            {
                letterGrade = $"A{(plusOrMinus == '+' ? ' ' : plusOrMinus)}";
            }
        }
```

#### Further studies and research 🕵🏾‍♂️ :

In Software development or programming in general, almost everything involves **Working with data** one way or the other. You take an input or information from the user and compute, store, or generation new information to give back to the user  
In C# and other programming languages, variables are defined by **_types_**. This determines what kind of data can be stored. C# offers many built-in types. Apart from the usual types like:

- `int` - that can store any integer from -2,147,483,648 to 2,147,483,647. They don't have decimal points.
- `float` - can store real numbers with up to 8 significant digits.
- `double` floats big brother (or so I think lol), can store real numbers up 16 sugnificant digits. It's common when working with XAML properties.
- `string` can hold text of any length and that includes empty strings - " ".
- `bool` short for boolean values - **true** or **false**.

There are other types for storing integers:

- **_byte_** stores any integer between **0 to 255**.
- **_sbyte_**('s' means **signed**) store any integer from **-128 to 127**.
- **_short_** store any integer from **-32,768 to 32,767**.
- **_long_** store any integer from **–9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.**  
  The unsigned version of int, short and long:
- **_uint_** store any whole number from **0 to 65,535.**
- **_ushort_** store any whole number from **0 to 4,294,967,295.**
- **_ulong_** store any whole number from **0 to 18,446,744,073,709,551,615.**

In cases of programs intended for science or finance, float just doesn't suffice. C#, you guessed it, then gives us different floating-point types to handle tiny and huge values:

> before that, ±1.5 × 10–45 to ±3.4 × 1038 means 34 followed by 37 zeros, and -.00...(40 more zeros)...0015.

- **_float_** store any number from **±1.5 × 10–45 to ±3.4 × 1038** with 6–9 significant digits.
- **_double_** store any number from **±5.0 × 10–324 to ±1.7 × 10308** with 15–17 significant digits.
- **_decimal_** store any number from **±1.0 × 10–28 to ±7.9 × 1028** with 28–29 significant digits. It is commonly used wghen dealing with money or currency. It has a lot more precision.

**Strings**... Strings are characters strung together (pun intended 😃), specially unicode characters. Now in C#, if you want to use a single character like `@` or `s`, you the **char** type accompany with a single quote like this `char aLetter = 'k'` oppose to `string myInitials = "ST"`. In any .NET application, string is an object of the **System** namespace - `System.String`.  
C# also have **Object** which are like dictionaries in Python. They are also from the System namespace.

Variables are like boxes we can store our data. In C#, these boxes different sizes of data values. For example:
|byte|short|int|long|float|double|decimal|bool|char|string|
|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|
|8bits|16bits|32bits|64bits|32bits|64bits|128bits|8bits|16bits|Depends on the size|

C# being a gentle man, gives us a static class (which means we don't need to instantiate) called **Convert**, that convert between two different data types. Example:

```C#
    Convert.ToByte("10111", 2)   // returns 23
    Convert.ToInt16("111111111111111", 2);   // returns 32767
    Convert.ToInt32("1111111111111111111111111111111", 2);   // returns 2147483647
```

> The first argument to Convert.ToByte/Int is the number to convert, and the second is its base. Binary numbers are base 2.

The same goes for other types having different sizes too.

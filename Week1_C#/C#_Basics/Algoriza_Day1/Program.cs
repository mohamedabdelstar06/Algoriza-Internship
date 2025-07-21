#region string Format 
////string Format
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

var message = string.Format("There are {0} Computers", 9); //first way
Console.WriteLine(message);


var strbuilder = new StringBuilder("");
strbuilder.AppendFormat("There are {0} users online ", 5); //secound way
Console.WriteLine(strbuilder);
Console.WriteLine(strbuilder.Length);
Console.WriteLine(strbuilder.Replace('e', 'M'));


Console.WriteLine("There are {0} Computers", 9); // theird way

var total = 114;
Console.WriteLine("There are {0} Computers", total); //fourth 

Console.WriteLine("-------------------------------------------");

Console.WriteLine("Number : {0:N}", 90);// 90.00
Console.WriteLine("Number : {0:C}", 90);   // $90.00

Console.WriteLine("Number : {0:P}", 0.90); //90.00%

Console.WriteLine("Number : {0:D7}", 1000); // 0001000

Console.WriteLine("Number : {0:X}", 9456780); //  904C8C
#endregion

#region String Interpolation 
var onlineUsers = 7;
//var totalUsers = 1500;
Console.WriteLine($" Total user is {totalUsers} and the online users is {onlineUsers}");
#endregion

#region DateTime 

DateTime dateTime = DateTime.Now;
Console.WriteLine(dateTime);

string formattedDate = string.Format("Date is {0:yy-MM-dd MMMM dddd HH:mm:ss tt}", dateTime);

string formattedDate2 = $"Date is {dateTime: yy-MM-dd MMMM dddd HH:mm:ss tt}";
Console.WriteLine(formattedDate);
Console.WriteLine(formattedDate2);
///////////////////////////////////////////////////////////////////
using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

DateTime dateTime1 = new DateTime(2025, 07, 8);

string formattedDate = string.Format("Date is {0:yy-MM-dd MMMM dddd HH:mm:ss tt}", dateTime1);
Console.WriteLine(dateTime1);




#endregion

#region Date & Time Only 
////Date only
//DateOnly date = new DateOnly(2025, 07, 08);
//Console.WriteLine(date);
//string formattedDateOnly = $"{date:yy-MM-dd dddd}";
//Console.WriteLine(date.DayOfWeek);
//Console.WriteLine(date.DayOfYear);
//Console.WriteLine(date.DayNumber);
//Console.WriteLine(date.AddMonths(2).AddYears(30));
//Console.WriteLine(formattedDateOnly);
//var currentDate = DateOnly.FromDateTime(DateTime.Now);
//Console.WriteLine(currentDate);

////Time Only 
//TimeOnly eventIn = new TimeOnly(8, 30);
//TimeOnly eventOut = new TimeOnly(17, 0);
//Console.WriteLine(eventIn);
//Console.WriteLine(eventOut);
//var span = eventOut - eventIn;
//Console.WriteLine($"Duration :{span.TotalHours}");
//Console.WriteLine(span);
#endregion

#region DateTime Exercise 

//Console.WriteLine("Enter your birth date ");
//DateTime birthDate = DateTime.Parse(Console.ReadLine());
//Console.WriteLine(birthDate.DayOfWeek);

//Console.WriteLine($"{birthDate.DayOfWeek} and month is {birthDate:MMM} and year is {birthDate.Year}");

#endregion

#region Naming Convention and best practises 
// C# Best Practise for naming local variable : Camel Case => employeeFirstName
// C# Best Practise for naming Functions , Classes , Struct : Pascal Case => EmployeeFirstName
// Snake Case => employee_first_name 
// Kebab Case => employee-first-name
// Upper Case for constants Gravity= 9.8 

#endregion

#region Arithmatic Operator
//int result = 0;
//int x = 12, y = 4;

//result =x+y;
//Console.WriteLine($" Addition : {result}");

//result =x-y;
//Console.WriteLine($" Subtraction : {result}");

//result =x*y;
//Console.WriteLine($" Multiplication : {result}");

//result =x/y;
//Console.WriteLine($" Division : {result}");

//result =x%y;
//Console.WriteLine($" Reminder : {result}");
#endregion

#region Operators
//Priority=> () => * / => + -

//Postfix Increement Operator 
//var i = 0;
//Console.WriteLine(i);
//Console.WriteLine(i++);
//Console.WriteLine(i);

////Prefix Increment Operator 

//var x = 0;
//Console.WriteLine(x);
//Console.WriteLine(++x);
//Console.WriteLine(x);

/*
== equal to 
> Greater than 
< smaller than 
>= Greater than or equal to
<= smaller than or equal to
!= Not equal to 
*/

//bool result;
//int x = 5, y = 7;
//result =x != y;
//Console.WriteLine($"{x} Not equal to {y} ?{result}");

//Operator Exercise
//int a = 5, b = 6, c = 5;
//var result = 4 + ((++a)*b)-(++c)*2;
// 4+ (36) - (12)= 40 - 12 =28

//Console.WriteLine(result);

//int x = 5;
//int y = x++;
//Console.WriteLine(x);
//Console.WriteLine(y);
//const int x = 6;
//Console.WriteLine(x++); // Compilation error when reDeclare constant variable


#endregion

#region Conditional Statement 
//int x = 7, y =7;
//if (x>y)
//{
//    Console.WriteLine($"x is greater than y");
//}
//else if(x<y)
//{
//    Console.WriteLine($"x is less than y");
//}
//else if ( x == y )
//{
//    Console.WriteLine($"x equal to y");
//}

#endregion

#region Nested IF 

//Console.WriteLine("Enter the value of x");
//int x = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter the value of y");
//int y = int.Parse(Console.ReadLine());

//if(x == y)
//{
//    Console.WriteLine("X is equal to y");
//}else 
//{
//    if (x>y)
//    { 
//            Console.WriteLine("x is greater than y");
//    }else
//    { 
//        Console.WriteLine("x is lower than y ");
//    }
//}
#endregion

#region Logical Operators 
//Console.WriteLine("Are you have licencs ?");
//bool hasLicense = bool.Parse(Console.ReadLine());
//Console.WriteLine("Are you know how ? ");
//bool knowWho = bool.Parse(Console.ReadLine());

//// And Opeator
//if (hasLicense && knowWho)
//{
//    Console.WriteLine("Good");
//}
//else if (hasLicense && !knowWho)
//{
//    Console.WriteLine("Bad");
//}
//else if (!hasLicense && !knowWho)
//{
//    Console.WriteLine("Bad");
//}
//else if (!hasLicense && knowWho)
//{
//    Console.WriteLine("Bad");
//}

// OR Operator
//Console.WriteLine("Did you go for a swim?");
//bool wentForSwim = bool.Parse(Console.ReadLine());
//Console.WriteLine("Did you take a shower?");
//bool tookShower = bool.Parse(Console.ReadLine());

//if (wentForSwim || tookShower)
//{
//    Console.WriteLine("Wet");
//}
//else
//{
//    Console.WriteLine("Dry, you should swim");
//}

// NOT Operator
//bool userName = true;
//bool email = true;
//bool password = false;
//Console.WriteLine(!userName);

//if ((userName || email ) && password) // AND Operator has highly priority
//{
//    Console.WriteLine("login Acceptable");
//}
//else
//{
//    Console.WriteLine("Invalid UserName / Password");
//}
#endregion

#region Ternary Operator
//int x = 10, y = 100;
//if (x>y)
//{
//    Console.WriteLine($"x is greater than y");
//}
//else
//{
//    Console.WriteLine($"x is less than y");
//}

// The new way Ternary Operator

//Console.WriteLine((x>y) ? "x is greater than y" : "x is less than y");

//Console.WriteLine("Enter to determine this number is even or odd");

//int z = int.Parse(Console.ReadLine());


//Console.WriteLine((z %2 ==0 )? "z is even " : "z is odd");

#endregion

#region Switch Statement 
//Console.WriteLine("Street Status");
//var currentTrafficLight = decimal.Parse(Console.ReadLine());
//switch (currentTrafficLight)
//{
//    case <= 20.0m:
//        Console.WriteLine("The weather is cold ");
//        break;
//    case <= 30.0m:
//        Console.WriteLine("The weather is worm");
//        break;
//    case >30.0m:
//        Console.WriteLine("The weather is Hot");
//        break;
//}


/// Switch Expression
//var message = currentTrafficLight switch
//{
//    "Red" => "STOP",
//    "Green" =>"Pass",
//    "Yellow" =>"Slow Down",
//};

//Console.WriteLine(message);
#endregion

#region Nullable Type
//string? number1 = null; // first way
//Nullable<int> number2 = null;  //second way

//Null Coalescing Operator
//double? number3 = 150;
//double total = number3 ?? 0; // Null Coalescing return the value if exist if not exist return Null
//Console.WriteLine(total);

//string message = "null";
//string result = message ?? "No new messages";

//Console.WriteLine(result);


// Try Parse
//int x = int.Parse(Console.ReadLine());
//int.TryParse(Console.ReadLine(), out int x);
//Console.WriteLine(x);
//Console.WriteLine(x==0 ? "In valid operator" : $"your number is :{x}");
#endregion

#region  String Manipulation 
//string moveName = "    loard of the RINGS     ";

////Trim 
//Console.WriteLine(moveName.Trim());

////Indexes 
//Console.WriteLine(moveName[18]);

////UpperCase
//Console.WriteLine(moveName.ToUpper().Trim());

////LowerCase
//Console.WriteLine(moveName.ToLower().Trim());

////Length
//Console.WriteLine(moveName.Trim().Length);
//Console.WriteLine(moveName.Length);

////Replace
//Console.WriteLine(moveName.Replace("loard", "Mohamed Abdelstar"));
//Console.WriteLine(moveName.Replace('l', 'L'));

////Index of
//Console.WriteLine(moveName.IndexOf('S'));

////Last Index of 
//Console.WriteLine(moveName.Trim().Substring(4));

////Insert
//Console.WriteLine(moveName.Trim().Insert(0, "The ").Insert( 22, "??"));

////Contains
//if(moveName.Contains("loard"))
//{
//    Console.WriteLine(moveName);
//}


#endregion

#region Interpolated verbatim string 
//string normalString = "Build completed at 11:05 AM  and took 00.970 seconds";
//string verbatimString = $@"Build completed at {normalString} https:/drive.google.com/drive/folders/1zEHYH716qpQRJ62tn3RhhtQKheV1qTHo
//11:05 AM and took 
//00.970 seconds";

//Console.WriteLine(normalString);
//Console.WriteLine(verbatimString);
//const int eee=1;

#endregion

#region For Loop 
//for( Initialization; Condition ; Iterator )
//{
//    body of for loop
//}

//for (int i = 5; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}

//int number = 9, sum = 0;
//for (int i = 0; i< number; i++)
//{
//    sum +=i;

//}
//Console.WriteLine($"The Sum ={sum}");

//int k = 1;
//for(; k <=5;)
//{
//    Console.WriteLine("For loop K = " +k);
//    k++;
//}
//for (int i = 20; i > 0; i--)
//{
//    Console.WriteLine(i);
//}


//Infinite loop
//for (byte i = 1; i>0; i++)
//{
//    Console.WriteLine($"The Iteration {i}");
//    //Condition to terminate loop

//}

//for (int i = 0, j = 0; i+j < 50; i++, j--)
//{
//    Console.WriteLine($"I value is = {i}, J Value is {j}");
//}
#endregion

#region While Loop 
//int i = 1;
//while (i<=5)
//{
//    var strFormat = String.Format("Iteration {0} ", i);
//    Console.WriteLine(strFormat);
//    i++;
//}



#endregion

#region Multiplication Table جدول الضرب  

//int i = 1, n = 12, result = 0;
//for (n=1; n <= 12; n++)
//{
//    i=1;
//    Console.WriteLine($"Table = {n}");
//    while (i <= 12)
//    {
//        result = n * i;
//        Console.WriteLine($"{n} * {i} = {result}");
//        i++;
//    }
//    Console.WriteLine("\n");
//}
#endregion

#region Traingle Excercise 

//for (int i = 0; i <=10; i++)
//{
//    for (int j = 0; j<=i; j++)
//        Console.Write("* ");
//    Console.WriteLine();

//}

//for (int i = 9; i >=0; i--)
//{
//    for (int j = 0; j <= i; j++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}



//int n = 10; // عدد صفوف الهرم

//for (int i = 1; i <= n; i++)
//{
//    // نطبع مسافات
//    for (int space = 1; space <= n - i; space++)
//    {
//        Console.Write(" ");
//    }   

//    // نطبع نجوم مع مسافات بينها
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("* ");
//    }

//    Console.WriteLine();
//}

//for (int i = 1; i<=20; i++)
//{
//    Console.WriteLine(i*2);
//}

//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine(i * 2);
//}


#endregion

#region Array 

// Array is a structure representing a fixed length collection os values or objects with the same type

//int[] numbers = new int[5] { 1, 10, 100, 1000, 10000 };  //First way

//int[] newNumbers = { 1, 10, 100, 1000, 10000 }; //Second way

//var oldNumbers = new int[5] { 1, 10, 100, 1000, 10000 }; // Thierd way

//string [] cities = new string[5] { "Cairo ","Zag","Belbes","Vienna","Amisterdam" }; // Fourth way 

//cities[0]="2";

////For each 
//foreach (var city in cities)
//{
//    Console.WriteLine(city);
//}
#endregion

#region Traversing 1D array 

//char[] genders = {'m','f', 'm', 'f', 'm', 'f', 'm', 'm', 'f', 'm', 'f', 'm', };

//int males = 0, females = 0;
//foreach (var gender in genders)
//{
//    if (gender =='m')
//    {
//        males++;
//    }
//    else if(gender == 'f' )
//    {
//        females++;
//    }

//}
//Console.WriteLine($"The number of males = {males}");
//Console.WriteLine($"The number of females = {females}");

#endregion

#region Find Min and Max element in array 

// Hard way 
//int[] numbers = new int[5] { 123, 9034, 456, 56, 89 };

//int max = 0;
//max= numbers[0];
//for (int i = 0; i<numbers.Length; i++)
//{
//    if (numbers[i] >max)
//    {
//        max =numbers[i];
//    }
//}
//Console.WriteLine(max);

// Easy way 
//Console.WriteLine(numbers.Max());

#endregion

#region Sorting array using Bubble sort 

// Hard way 


#endregion


#region Initialization method 
//public int AddNumbers(int  firstNumber ,int secondNumber)
//{
//   return firstNumber + secondNumber;

//}
//public  void EvenNumbers(int target) //Instance Method
//{
//    int start = 0;
//    while (start <= target)
//    {
//        Console.WriteLine(start);
//        start +=2;
//    }
//}
#endregion

#region Method Parameter 
//Program.SimpleMethod(ref i);
//// Pass by reference => I and J Pointing to the same memory location
//// Pass by reference => Any changes made to the parameter will be reflected in the variable

//    int sum = 0;
//    int product = 0;
//    Program.Add(5, 4,out sum,out product);
//    // pass by value j => i
//    Console.WriteLine($"Sum = {sum} and product = {product}");


//}

//// Method Parameters 
//public static void Add(int firstNumber , int secondNumber,out int sum ,out int product)
//{
//    sum = firstNumber + secondNumber;
//    product = firstNumber * secondNumber;
#endregion

#region OOP 
// TroubleShooting is easier 
// Code reusability and extensibility
// Productivity
// Readable
// Debugging is easy
// secuirity

// Disadvantage 
// Size is longer longer than programs 
// it require alot of effort to create 
// it takes time to get used to it.
// it can slower than programs
// Not suitable for some sorts problems


#endregion

#region Methods 
//// Block of code that contains a series of statements the program can be excuted by calling a method
//static int Add(int x , int y)
//{
//    return x + y;
//}

#endregion

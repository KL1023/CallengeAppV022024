// var myAge = 33;
int myAge = 120;
int newAge = myAge + 5;
//Console.WriteLine(newAge);

// liczby calkowite
int myVar = int.MinValue;
uint myVar2 = uint.MaxValue;
long myVar3 = long.MaxValue;
ulong myVar4 = ulong.MaxValue;

// liczby zmiennoprzecinkowe
float myNumber = float.MaxValue;
double myNumber2 = double.MaxValue;
decimal myNumber3 = decimal.MaxValue;

// zmienne tekstowe
string name = "Adam";
string surname = "Kamizelich";
string result = name + surname + myAge;
// Console.WriteLine(result);
var result2 = name.ToArray();

// zmienna logiczna
bool isActive = true;
isActive = false;
var isValid = 5 > 6;
// Console.WriteLine(isValid);

// instrukcja if

var number1 = 50;
var number2 = 10;

// operatory relacyjne
// >
// <
// >=
// <=
// ==
// != 

if (number1 < number2)
{
    Console.WriteLine("Jestem w linii 37");
}
else
{
    Console.WriteLine("Jestem w linii 41");
}

// opratory logiczne
// && - i
// || - lub
// ! - negacja

var name1 = "Adam";
var age = 65;

if (name1 == "Adam" && age < 50)
{
    Console.WriteLine("Jestem Adamem przed 50.");
}
else
{
    Console.WriteLine("Jestem kims innym");
}


if (age < 50)
{
    Console.WriteLine("Jestem przed 50.");
}
else if (age < 60)
{
    Console.WriteLine("Jestem 50-latkiem");
}
else if (age < 65)
{
    Console.WriteLine("Jestem 60-latkiem");
}
else
{
    Console.WriteLine("W koncu emerytura - jestem Emerytem!");
}

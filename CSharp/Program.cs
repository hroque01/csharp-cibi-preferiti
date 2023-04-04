// See https://aka.ms/new-console-template for more information

//Array
string[] FoodsArray = { "Pasta alla Carbonara", "Pizza Diavola", "Nighiri al salmone", "Piadina Kebab", "Torta al cioccolato", "Risotto Mantovano", "Adobo", "Tofu fritto", "Ravioli gamberi"};

//Print Lenght
Console.WriteLine("Your list is made with " + FoodsArray.Length + " elements");

//Print array
for (int i = 0; i < FoodsArray.Length; i++)
{
    Console.WriteLine(i + 1 + " " + FoodsArray[i]);
}

//Print my favourite dishes
var myFavourite = FoodsArray.First();
Console.WriteLine("My favourite is " + myFavourite);

//Print my favourite dishes
var myLatestFavourite = FoodsArray.Last();
Console.WriteLine("Last dish " + myLatestFavourite);

//BONUS: Print the middle string of the array ODD
var mid = FoodsArray[FoodsArray.Length / 2];
Console.WriteLine("Odd Array, the middle string is: " + mid);

//BONUS: Print the middle string of the array EVEN
string[] FoodsArray2 = { "Pasta alla Carbonara", "Pizza Diavola", "Nighiri al salmone", "Piadina Kebab", "Torta al cioccolato", "Risotto Mantovano", "Adobo", "Tofu fritto", "Ravioli gamberi", "poke" };

var middle = FoodsArray2[FoodsArray2.Length / 2 - 1];
var middle2 = FoodsArray2[FoodsArray2.Length / 2];
Console.WriteLine("Even array, the middle strings are: " + middle + middle2);




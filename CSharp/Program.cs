// See https://aka.ms/new-console-template for more information

//Array
string[] FoodsArray = { "Pasta alla Carbonara", "Pizza Diavola", "Nighiri al salmone", "Piadina Kebab", "Torta al cioccolato", "Risotto Mantovano", "Adobo", "Tofu fritto", "Ravioli gamberi" };

//Print Lenght
Console.WriteLine("Your list is made with " + FoodsArray.Length + " element");

//Print array
for (int i = 0; i < FoodsArray.Length; i++)
{
    Console.WriteLine(i + 1 + " " + FoodsArray[i]);
}

//Print my favourite dishes
var myFavourite = FoodsArray.First();
Console.WriteLine("My favourite is " + myFavourite);
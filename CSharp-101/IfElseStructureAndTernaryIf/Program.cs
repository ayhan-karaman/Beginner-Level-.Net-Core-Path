﻿// See https://aka.ms/new-console-template for more information
var time = DateTime.Now.Hour;
if (time >= 6 && time <= 11)
{
    Console.WriteLine("Günaydın!");
}
else if (time <= 18)
{
    Console.WriteLine("İyi Günler!");
}
else
{
    Console.WriteLine("İyi Geceler!");
}

string result = time >= 6 && time <= 11 ? "Günaydın" : "İyi Günler";

result = time >= 6 && time <= 11 ? "Günaydın!" : time <= 18 ? "İyi Günler!" : "İyi Geceler!";
Console.WriteLine(result);

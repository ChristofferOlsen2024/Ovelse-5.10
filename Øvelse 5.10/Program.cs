﻿// See https://aka.ms/new-console-template for more information
string adgangskode;
int antal = 0;
do
{
    Console.WriteLine("Indtast dit password");
    adgangskode = Console.ReadLine();
    antal++;
} while (adgangskode != "password" && antal < 3);
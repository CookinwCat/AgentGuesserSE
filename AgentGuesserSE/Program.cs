﻿using System.Drawing;
using System.IO;

string[] agents = { "Jett","Raze", "Reyna", "Neon", "Phoenix", "Yoru", "Gekko",
    "Sova", "Fade", "Kayo","Skye", "Breach", "Cypher", "Sage", "Killjoy",
    "Chamber", "Omen", "Viper", "Harbor", "Brimstone", "Astra"};
Console.WriteLine("Cs budeš hádat agentíky, mapy a itemy z vala uwu");

Random generatorCisel = new Random();
int nahodnyindex = generatorCisel.Next(0, 21);
string hadanyAgent = agents[nahodnyindex];
string releaseDate = "";
string role = "";
double pickRate = 0.1;
string Narodnost = "";
int menu = 0;
string choice;
int Streak = 0;
int Coins = 0;

while (menu == 0)
{
    Console.WriteLine("1) Start\n2) Coin balance\n3) Momentální streak\n4) EXIT");
    choice = Console.ReadLine();
    if (choice == "1")
    {
        menu++;
    }
    else if (choice == "2")
    {
        Console.WriteLine($"Momentálně máš {Coins} Coinů!");
        Thread.Sleep(3000);
    }
    else if (choice == "3")
    {
        Console.WriteLine($"Momentální streak je {Streak}. Nezapomeň že streak se po vypnutí restartuje :c");
        Thread.Sleep(5000);
    }
    else if (choice == "4")
    {
        goto exit;
    }
}

if (hadanyAgent == "Jett")
{
    releaseDate = "Beta";
    role = "Duelist";
    pickRate = 10;
    Narodnost = "Jižní Korea";
}
else if (hadanyAgent == "Raze")
{
    releaseDate = "1.0";
    role = "Duelist";
    pickRate = 6.5;
    Narodnost = "Brazílie";
}
else if (hadanyAgent == "Reyna")
{
    releaseDate = "1.0";
    role = "Duelist";
    pickRate = 11.8;
    Narodnost = "Mexico";
}
else if (hadanyAgent == "Neon")
{
    releaseDate = "4.0";
    role = "Duelist";
    pickRate = 2.2;
    Narodnost = "Filipíny";
}
else if (hadanyAgent == "Phoenix")
{
    releaseDate = "Beta";
    role = "Duelist";
    pickRate = 3.4;
    Narodnost = "Británie";
}
else if (hadanyAgent == "Yoru")
{
    releaseDate = "2.0";
    role = "Duelist";
    pickRate = 1.8;
    Narodnost = "Japonsko";
}
else if (hadanyAgent == "Gekko")
{
    releaseDate = "6.04";
    role = "Initiator";
    pickRate = 6.2;
    Narodnost = "USA";
}
else if (hadanyAgent == "Sova")
{
    releaseDate = "Beta";
    role = "Initiator";
    pickRate = 4.2;
    Narodnost = "Rusko";
}
else if (hadanyAgent == "Fade")
{
    releaseDate = "4.08";
    role = "Initiator";
    pickRate = 3.2;
    Narodnost = "Turecko";
}
else if (hadanyAgent == "Kayo")
{
    releaseDate = "3.0";
    role = "Initiator";
    pickRate = 2.7;
    Narodnost = "Alternative Earth";
}
else if (hadanyAgent == "Skye")
{
    releaseDate = "1.11";
    role = "Initiator";
    pickRate = 3.3;
    Narodnost = "Austrálie";
}
else if (hadanyAgent == "Breach")
{
    releaseDate = "Beta";
    role = "Initiator";
    pickRate = 2.6;
    Narodnost = "Švédsko";
}
else if (hadanyAgent == "Cypher")
{
    releaseDate = "Beta";
    role = "Sentinel";
    pickRate = 3.3;
    Narodnost = "Maroko";
}
else if (hadanyAgent == "Sage")
{
    releaseDate = "Beta";
    role = "Sentinel";
    pickRate = 10.7;
    Narodnost = "Čína";
}
else if (hadanyAgent == "Killjoy")
{
    releaseDate = "1.05";
    role = "Sentinel";
    pickRate = 6.5;
    Narodnost = "Německo";
}
else if (hadanyAgent == "Chamber")
{
    releaseDate = "3.10";
    role = "Sentinel";
    pickRate = 2.8;
    Narodnost = "Francie";
}
else if (hadanyAgent == "Omen")
{
    releaseDate = "Beta";
    role = "Controller";
    pickRate = 7.3;
    Narodnost = "Unknown";
}
else if (hadanyAgent == "Viper")
{
    releaseDate = "Beta";
    role = "Controller";
    pickRate = 3.8;
    Narodnost = "USA";
}
else if (hadanyAgent == "Harbor")
{
    releaseDate = "5.08";
    role = "Controller";
    pickRate = 1.1;
    Narodnost = "Indie";
}
else if (hadanyAgent == "Brimstone")
{
    releaseDate = "Beta";
    role = "Controller";
    pickRate = 5;
    Narodnost = "USA";
}
else if (hadanyAgent == "Astra")
{
    releaseDate = "2.04";
    role = "Controller";
    pickRate = 1.5;
    Narodnost = "Ghana";
}
while (true)
{
    Console.WriteLine("Tvuj guess");
    Console.WriteLine("Hints:\nRealeaseDate - 1\nRole - 2\nPick Rate - 3\nNárodnost - 4");
    string odhadAgenta = Console.ReadLine();
    if (odhadAgenta == hadanyAgent)
    {
        Console.WriteLine("GG!");
        Thread.Sleep(1000);
        break;
    }
    else if (odhadAgenta == "1")
    {
        Console.WriteLine(releaseDate);
    }
    else if (odhadAgenta == "2")
    {
        Console.WriteLine(role);
    }
    else if (odhadAgenta == "3")
    {
        Console.WriteLine(pickRate + "%");
    }
    else if (odhadAgenta == "4")
    {
        Console.WriteLine(Narodnost);
    }
    else
    {
        Console.WriteLine("Nn zkus znova");
        Thread.Sleep(1000);
        Console.Clear();
    }
}
exit:
Console.WriteLine("To bylo moc ez.... Myslim že je čas nerfnout Chambera.");

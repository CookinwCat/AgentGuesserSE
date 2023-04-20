using System.Drawing;
using System.IO;

string[] agents = { "Jett","Raze", "Reyna", "Neon", "Phoenix", "Yoru", "Gekko",
    "Sova", "Fade", "Kayo","Skye", "Breach", "Cypher", "Sage", "Killjoy",
    "Chamber", "Omen", "Viper", "Harbor", "Brimstone", "Astra"};
Console.WriteLine("Cs budeš hádat agentíky.");


string releaseDate = "";
string role = "";
double pickRate = 0.1;
string Narodnost = "";
int menu = 0;
string choice;
int Streak = 0;
int Coins = 0;
string choice2;
int guess = 0;
int nahodnyindex = 0;

Menu:

while (menu == 0)
{
    Console.WriteLine("1) Start\n2) Coin balance\n3) Momentální streak\n4) Pravidla\n5) EXIT");
    choice = Console.ReadLine();
    if (choice == "1")
    {
        Random generatorCisel = new Random();
        nahodnyindex = generatorCisel.Next(agents.Length);
        Console.Clear();
        menu++;
    }
    else if (choice == "2")
    {
        Console.WriteLine($"Momentálně máš {Coins} Coinů!");
        Thread.Sleep(3000);
        Console.Clear();
    }
    else if (choice == "3")
    {
        Console.WriteLine($"Momentální streak je {Streak}. Nezapomeň že streak se po vypnutí restartuje :c");
        Thread.Sleep(5000);
        Console.Clear();
    }
    else if (choice == "4")
    {
        Console.Clear();
        Console.WriteLine("Dělení coinů:\nZa každý špatný guess dostanete 1 coin\npokud uhodnete do 5ti pokusů dostanete 3 coiny\ndo 10ti pokusů 2 coiny\nZa splnění po více než 10ti pokusech 1 coin");
    }
    else if (choice == "5")
    {
        goto exit;
    }
}
menu = 0;
string hadanyAgent = agents[nahodnyindex];
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
    Console.WriteLine($"Hints:\n1) RealeaseDate - 3$\n2) Role - 4$\n3) Pick Rate - 1$\n4) Národnost - 5$\nMomentálně máš {Coins}$");
    string odhadAgenta = Console.ReadLine();
    if (odhadAgenta == hadanyAgent)
    {
        Console.WriteLine("GG!");
        Thread.Sleep(1000);
        if (guess <= 5)
        {
            Coins = Coins +3;
        }
        else if (guess <= 10) 
        {
            Coins = Coins + 2;
        }
        else
        {
            Coins = Coins ++;
        }
        Streak++;
        guess = 0;
        Console.WriteLine("1)Menu\n2)exit(Streak a goldy budou ztraceny.)");
        choice2 = Console.ReadLine();
        if(choice2 == "1")
        {
            Console.Clear();
            goto Menu;
        }
        if (choice2 == "2")
        {
            Console.Clear();
            goto exit;
        }
    }
    else if (odhadAgenta == "1")
    {
        if (Coins >= 3)
        {
            Coins = Coins - 3;
            Console.WriteLine(releaseDate);
            Thread.Sleep(5000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Nedostatek Coinů!");
        }

    }
    else if (odhadAgenta == "2")
    {
        if (Coins >= 4)
        {
            Coins = Coins - 4;
            Console.WriteLine(role);
            Thread.Sleep(5000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Nedostatek Coinů!");

        }

    }
    else if (odhadAgenta == "3")
    {
        if (Coins >= 1)
        {
            Coins = Coins --;
            Console.WriteLine(pickRate + "%");
            Thread.Sleep(5000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Nedostatek Coinů!");
            Thread.Sleep(5000);
            Console.Clear();
        }
    }
    else if (odhadAgenta == "4")
    {
        if (Coins >= 5)
        {
            Coins = Coins - 5;
            Console.WriteLine(Narodnost);
            Thread.Sleep(5000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Nedostatek Coinů!");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
    else
    {
        Console.WriteLine("Nn zkus znova");
        guess++;
        Coins++;
        Thread.Sleep(1000);
        Console.Clear();
    }
}
exit:
Console.WriteLine("To bylo moc ez.... Myslim že je čas nerfnout Chambera.");

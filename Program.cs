// See https://aka.ms/new-console-template for more information

/*
Kalkulacka ma zakladni funkce +, -, *, /, 
pri zadavani se musi hodnoty od operatoru oddelit mezerou, kvuli naslednemu deleni na hodnoty a operatory.
Pocita s desetinymi cisly, je ale treba davat pozor na posloupnost operatoru, zatim nema nastavenou
preferenci operatoru, takze pri spatnem zadani muze dojit k chybe.
Kod jsem sestavil sam, ale dokumentaci, hledani funkci a na debugovani jsem vyuzival hledani rozsirene
umelou inteligenci
*/
using System;
using System.Linq.Expressions;
string input;
double result = 0;




do 
{
    Console.WriteLine("zadejte vstupy, mezi cisly a operatory musi byt mezera!");
    input = Console.ReadLine();
    string[] parts = input.Split(' ');          //rozdeli vstup na casti tam kde je mezera
    for (int i = 0; i < parts.Length; i++)
    {
        double num = 0;                         //prvni nacteni, reseno specificky
        if (i == 0)         
            double.TryParse(parts[i], out result);

        switch (parts[i])                       //zjisteni operatoru a prirazeni aplikaci
        {

            case "+":
                if (double.TryParse(parts[i + 1], out num))
                    result += num;              
                else
                    // token +1 neni cislo - ignorujeme
                    Console.WriteLine("Token #{0}({1}) neni cislo - ignoruji.", i+1, parts[i+1]);
                break;
            case "-":
                if (double.TryParse(parts[i + 1], out num))
                    result -= num;
                else
                    // token +1 neni cislo - ignorujeme
                    Console.WriteLine("Token #{0}({1}) neni cislo - ignoruji.", i + 1, parts[i + 1]);
                break;
            case "*":
                if (double.TryParse(parts[i + 1], out num))
                    result = result * num;
                else
                    // token +1 neni cislo - ignorujeme
                    Console.WriteLine("Token #{0}({1}) neni cislo - ignoruji.", i + 1, parts[i + 1]);
                break;
            case "/":
                if (double.TryParse(parts[i + 1], out num))
                    result = result / num;
                else
                    // token +1 neni cislo - ignorujeme
                    Console.WriteLine("Token #{0}({1}) neni cislo - ignoruji.", i + 1, parts[i + 1]);
                break;
            case "=":
                Console.WriteLine("vysledek je: " + result);
                break;
        }
    }
    result = 0;                             //vynulovani hodnot
    input = "";
    for (int i = 0; i < parts.Length; i++)
    {
        parts[i] = "";
    }
    Console.WriteLine("Zadejte jakoukoliv klavesu pro pokracovani nebo zmacknete klavesu 0 pro EXIT");
}
while (Console.ReadLine() != "0");


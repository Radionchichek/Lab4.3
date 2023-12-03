using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
}

    private static string ОтриматиДані()
    {
        return "Дані отримані від робочої станції";
    }

    private static void ПередатиДані(Компютер іншийКомп, string дані)
    {
        Console.WriteLine($"Робоча станція передала дані комп {іншийКомп.IPАдреса}: {дані}");
    }

    private static void Відключити(Компютер іншийКомп)
    {

        Console.WriteLine($"Робоча станція відключилася від комп {іншийКомп.IPАдреса}");
    }
}


class Компютер
{
    public string IPАдреса { get; set; }
    public int Потужність { get; set; }
    public string ТипОС { get; set; }
}

interface IConnectable
{
    void Зєднати(Компютер іншийКомп);
    void Відключити(Компютер іншийКомп);
    void ПередатиДані(Компютер іншийКомп, string дані);
    string ОтриматиДані();
}

class Сервер : Компютер, IConnectable
{
    public void Зєднати(Компютер іншийКомп)
    {
        Console.WriteLine($"Сервер зєднався з комп {іншийКомп.IPАдреса}");
    }

public void Відключити(Компютер іншийКомп)
    {

    Console.WriteLine($"Сервер відключився від комп {іншийКомп.IPАдреса}");
    }

    public void ПередатиДані(Компютер іншийКомп, string дані)
    {
        Console.WriteLine($"Сервер передав дані комп {іншийКомп.IPАдреса}: {дані}");
    }

    public string ОтриматиДані()
{
    return "Дані отримані від сервера";
}
}

class РобочаСтанція : Компютер, IConnectable
{
    public void Зєднати(Компютер іншийКомп)
    {
        Console.WriteLine($"Робоча станція зєдналася з компютером {іншийКомп.IPАдреса}");
    }

public void Відключити(Компютер іншийКомп)
    {

    Console.WriteLine($"Робоча станція відключилася від компютера {іншийКомп.IPАдреса}");
    }

    public void ПередатиДані(Компютер іншийКомп, string дані)
    {
        Console.WriteLine($"Робоча станція передала дані компютеру {іншийКомп.IPАдреса}: {дані}");
    }

    public string ОтриматиДані()
{
    return "Дані отримані від робочої станції";
}
}
class Маршрутизатор : Компютер, IConnectable
{
    public void Зєднати(Компютер іншийКомп)
    {
        Console.WriteLine($"Маршрутизатор зєднався з комп {іншийКомп.IPАдреса}");
    }

public void Відключити(Компютер іншийКомп)
    {

    Console.WriteLine($"Маршрутизатор відключився від комп {іншийКомп.IPАдреса}");
    }

    public void ПередатиДані(Компютер іншийКомп, string дані)
    {
        Console.WriteLine($"Маршрутизатор передав дані комп {іншийКомп.IPАдреса}: {дані}");
    }

    public string ОтриматиДані()
{
    return "Дані отримані від маршрутизатора";
}
}

class Мережа
{
    private List<Компютер> Компютери;

    public Мережа()
    {
        Компютери = new List<Компютер > ();
    }

    public void ДодатиКомпютер(Компютер комп)
    {
        Компютери.Add(комп);
    }

public void Зєднати(Компютер комп1, Компютер комп2)
    {
        комп1.Зєднати(комп2);
    }

    public void Відключити(Компютер комп1, Компютер комп2)
{
    комп1.Відключити(комп2);
}

public void ПередатиДані(Компютер комп1, Компютер комп2, string дані)
{
    комп1.ПередатиДані(комп2, дані);
}
}
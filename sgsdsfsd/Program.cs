using System;

class Device
{
    protected string Name;
    protected string Description;

    public Device(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Устройство издает звук.");
    }

    public virtual void Show()
    {
        Console.WriteLine("Название: " + Name);
    }

    public virtual void Desc()
    {
        Console.WriteLine("Описание: " + Description);
    }
}

class Teapot : Device
{
    public Teapot(string name, string description) : base(name, description) { }

    public override void Sound()
    {
        Console.WriteLine("Чайник свистит: Фьююю!");
    }
}

class Microwave : Device
{
    public Microwave(string name, string description) : base(name, description) { }

    public override void Sound()
    {
        Console.WriteLine("Микроволновка пищит: Бип-бип!");
    }
}

class Car : Device
{
    public Car(string name, string description) : base(name, description) { }

    public override void Sound()
    {
        Console.WriteLine("Автомобиль сигналит: Би-би!");
    }
}

class Steamboat : Device
{
    public Steamboat(string name, string description) : base(name, description) { }

    public override void Sound()
    {
        Console.WriteLine("Пароход гудит: Туууу!");
    }
}

class Program
{
    static void Main()
    {
        Device d = new Teapot("Bosch", "Электрический чайник 2л");
        d.Show();
        d.Desc();
        d.Sound();
    }
}
//2
using System;

class MusicalInstrument
{
    protected string Name;
    protected string Description;

    public MusicalInstrument(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Инструмент издает звук.");
    }

    public virtual void Show()
    {
        Console.WriteLine("Название: " + Name);
    }

    public virtual void Desc()
    {
        Console.WriteLine("Описание: " + Description);
    }

    public virtual void History()
    {
        Console.WriteLine("История неизвестна.");
    }
}

class Violin : MusicalInstrument
{
    public Violin(string name, string description) : base(name, description) { }

    public override void Sound() => Console.WriteLine("Скрипка звучит: Скри-и-и!");
    public override void History() => Console.WriteLine("Скрипка появилась в XVI веке в Италии.");
}

class Trombone : MusicalInstrument
{
    public Trombone(string name, string description) : base(name, description) { }

    public override void Sound() => Console.WriteLine("Тромбон звучит: Брууу!");
    public override void History() => Console.WriteLine("Тромбон известен с XV века.");
}

class Ukulele : MusicalInstrument
{
    public Ukulele(string name, string description) : base(name, description) { }

    public override void Sound() => Console.WriteLine("Укулеле звучит: Тринь-тринь!");
    public override void History() => Console.WriteLine("Укулеле появилось на Гавайях в XIX веке.");
}

class Cello : MusicalInstrument
{
    public Cello(string name, string description) : base(name, description) { }

    public override void Sound() => Console.WriteLine("Виолончель звучит: Бууум!");
    public override void History() => Console.WriteLine("Виолончель появилась в XVI веке.");
}//3
using System;

abstract class Worker
{
    public abstract void Print();
}

class President : Worker
{
    public override void Print()
    {
        Console.WriteLine("Президент компании — руководит всей организацией.");
    }
}

class Security : Worker
{
    public override void Print()
    {
        Console.WriteLine("Охрана — обеспечивает безопасность.");
    }
}

class Manager : Worker
{
    public override void Print()
    {
        Console.WriteLine("Менеджер — управляет отделом.");
    }
}

class Engineer : Worker
{
    public override void Print()
    {
        Console.WriteLine("Инженер — разрабатывает и проектирует решения.");
    }
}

class Program
{
    static void Main()
    {
        Worker[] workers =
        {
            new President(),
            new Security(),
            new Manager(),
            new Engineer()
        };

        foreach (Worker w in workers)
            w.Print();
    }
}
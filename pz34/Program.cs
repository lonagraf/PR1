﻿Cabinet cabinet = new Cabinet();
cabinet.ZavCabinet = "Иванов И.И.";
cabinet.Square = 100;

Podsobka podsobka = new Podsobka();
podsobka.ZavCabinet = "Петров П.П.";
podsobka.Square = 45;
podsobka.SquarePodsobka = 15;

Console.WriteLine(cabinet.Show());
Console.WriteLine(podsobka.Show());
public class Cabinet 
{
    private string _zavCabinet;
    private int _square;
    public string ZavCabinet 
    {
        get { return _zavCabinet; }
        set { _zavCabinet = value;}
    }
    public int Square 
    {
        get { return _square; }
        set 
        {
            if (value >= 10 && value <= 100)
            {
                _square = value;
            }
            else
            {
                Console.WriteLine("Площадь должна быть в диапазоне от 10 до 100");
            }
        }
    }
    public virtual string Show()
    {
        return "Заведующий кабинетом: " + _zavCabinet + " Площадь кабинета: " + _square + "кв.м.";
    }
}
public class Podsobka : Cabinet
{
    private int _squarePodsobka;
    public int SquarePodsobka
    {
        get { return _squarePodsobka; }
        set
        {
            if (value >= 3 && value <= 15)
            {
                _squarePodsobka = value;
            }
            else
            {
                Console.WriteLine("Площадь должна быть в диапазоне от 3 до 15");
            }
        }
    }
    public override string Show()
    {
        return "Заведующий кабинетом: " + ZavCabinet + " Площадь кабинета: " + Square + "кв.м. Площадь подсобки: " + _squarePodsobka + "кв.м.";
    }
}
var classes = new List<Cabinet>
{
    new Cabinet("Иванов В.А.", 100),
    new Cabinet("Ошаров В.В.", 50),
    new Cabinet("Крид Е.Н.", 65),
    new Cabinet("Иванов Ъ.Й.", 9)
};
var Classes = (from c in classes where c.Square < 10 select c.ZavCabinet).ToList();
Classes.ForEach(c => Console.WriteLine(c));
Cabinet cabinet = new Cabinet();
Podsobka podsobka = new Podsobka();
Console.WriteLine(cabinet.Show());
Console.WriteLine(podsobka.Show());
public class Cabinet 
{
    private string _zavCabinet;
    private int _square;
    public Cabinet()
    {
        _zavCabinet = "Иванов И.И.";
        _square = 100;
    }
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
    public Cabinet (string zavcabinet, int square) 
    {
        this.ZavCabinet = zavcabinet;
        this.Square = square;
    }
    public virtual string Show()
    {
        return "Заведующий кабинетом: " + _zavCabinet + " Площадь кабинета: " + _square + " кв.м.";
    }
}
public class Podsobka : Cabinet
{
    private int _squarePodsobka;
    public Podsobka()
    {
        ZavCabinet = "Петров П.П.";
        Square = 45;
        _squarePodsobka = 15;
    }
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
        return "Заведующий кабинетом: " + ZavCabinet + " Площадь кабинета: " + Square + " кв.м. Площадь подсобки: " + _squarePodsobka + " кв.м.";
    }
}

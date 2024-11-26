/*using System;

public class C1
{
    // константы
    private const int PrConst = 1;
    private const string PrConstStr = "приватная";
    public const int PConst = 2;
    public const string PConstStr = "публичная";

    protected const int ProtConst = 3;
    protected const string ProtConstStr = "защищенная";

    //    поля
    private int prField;
    private string prFieldStr;

    public int pField;
    public string pFieldStr;

    protected int protField;
    protected string protFieldStr;

    //    свойства
    private int PrProp { get; set; }

    public int PProp { get; set; }

    protected int ProtProp { get; set; }

    //Конструктор по умолчанию
    public C1()
    {
        prField = 0;
        prFieldStr = "Default";
        pField = 0;
        pFieldStr = "Default";
        protField = 0;
        protFieldStr = "Default";

        PrProp = 0;
        PProp = 0;
        ProtProp = 0;
    }

    //Копирующий конструктор
    public C1(C1 other)
    {
        prField = other.prField;
        prFieldStr = other.prFieldStr;
        pField = other.pField;
        pFieldStr = other.pFieldStr;
        protField = other.protField;
        protFieldStr = other.protFieldStr;

        PrProp = other.PrProp;
        PProp = other.PProp;
        ProtProp = other.ProtProp;
    }

    //Конструктор с параметрами
    public C1(int privateFieldValue, string privateFieldStringValue, int publicFieldValue, string publicFieldStringValue, int protectedFieldValue, string protectedFieldStringValue,
        int privatePropertyValue, int publicPropertyValue, int protectedPropertyValue)
    {
        prField = privateFieldValue;
        prFieldStr = privateFieldStringValue;
        pField = publicFieldValue;
        pFieldStr = publicFieldStringValue;
        protField = protectedFieldValue;
        protFieldStr = protectedFieldStringValue;

        PrProp = privatePropertyValue;
        PProp = publicPropertyValue;
        ProtProp = protectedPropertyValue;
    }

    //методы
    private void PrMethod()
    {
        Console.WriteLine("Приватный вызван");
    }

    private string PrMethodReturn()
    {
        return "приватный стринговый метод";
    }

    public void PMethod()
    {
        Console.WriteLine("паблик метод");
    }

    public string PMethodReturn()
    {
        return "паблик стринг";
    }

    //получения значения  свойства
    public int GetPrPropValue()
    {
        return PProp;
    }

    public int GetProtPropValue()
    {
        return ProtProp;
    }

    //  вызов приватного метода
    public string CallPrMethodReturn()
    {
        return PrMethodReturn();
    }

    //    Защищенный метод
    protected void ProtMethod()
    {
        Console.WriteLine("защищенный метод");
    }
}

class Program
{
    static void Main(string[] args)
    {
        C1 obj1 = new C1();
        Console.WriteLine("Первый обьект");
        Console.WriteLine("Приватное свойство : " + obj1.GetPrPropValue());
        Console.WriteLine("публичное свойство: " + obj1.PProp);
        obj1.PMethod();
        Console.WriteLine("приватный стринговый метод: " + obj1.CallPrMethodReturn());
        Console.WriteLine("публичный стринговый метод: " + obj1.PMethodReturn());
        C1 obj2 = new C1(obj1);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("второй обьект");
        Console.WriteLine("приватное свойство " + obj2.GetPrPropValue());
        Console.WriteLine("публичное поле: " + obj2.pField);
        Console.WriteLine("протект свойство: " + obj2.GetProtPropValue());
        obj2.PMethod();
        Console.WriteLine("приватный метод с ретурном " + obj2.CallPrMethodReturn());
        Console.WriteLine("приватный метод с ретурном " + obj2.PMethodReturn());
        C1 obj3 = new C1(1, "приватный", 2, "публичный", 3, "протектед", 4, 5, 6);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("обьект 3");
        Console.WriteLine("приватное свойство: " + obj3.GetPrPropValue());
        Console.WriteLine("публичное поле: " + obj3.pField);
        Console.WriteLine("протектед свойство: " + obj3.GetProtPropValue());
        obj3.PMethod();
        Console.WriteLine("приватный метод с ретурном: " + obj3.CallPrMethodReturn());
        Console.WriteLine("публичный метод с ретурном: " + obj3.PMethodReturn());
    }
}*/
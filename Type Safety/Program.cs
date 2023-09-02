using System;

//ref link:https://www.youtube.com/watch?v=c544m_YpQg0&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=27
// upcast, downcast, safety
// inheritance, polymorphism required knowledge

//class Base                // recommended
class Base  : System.Object         // explicit compiler inheritance -- not optional
{
    public int baseValue;
    public void BaseMethod()
    {
        Console.WriteLine("BaseMethod()");
    }
}

class Derived : Base
{
    public float derivedValue;
    public void DerivedMethod()
    {
        Console.WriteLine("DerivedMethod()");
    }
}

class MainClass
{
    static void Main()
    {
        Base b = new Base();
        Derived d = new Derived();
        //b = d;  // implicit reference convertion
        //d = b;  // error: need  explicit casting not recommended
        d = (Derived)b; // safety off explicit casting -- RUNTIME ERROR --
    }
}
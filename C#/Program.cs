namespace Protected
{
    public class Program
    {
        static void Main(string[] args)
        {
            new Base().TestAccessInBaseClass();
            new Derived().TestAccessInDerivedClass();
            new NotDerived().TestAccessInNotDerivedClass();           
        }
    }
}

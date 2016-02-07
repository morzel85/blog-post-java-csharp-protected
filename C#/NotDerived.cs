namespace Protected
{
    public class NotDerived
    {
        public void TestAccessInNotDerivedClass()
        {
            // DIFFERENT BEHAVIOR IN JAVA AND C#!
            // For the below to work (instead of CS0122 compilation error) the field would
            // have to be public or protected internal:
            // System.Console.WriteLine(new Base().someProtectedFiled);
        }
    }
}

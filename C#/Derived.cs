namespace Protected
{
    public class Derived : Base
    {
        public void TestAccessInDerivedClass()
        {
            // SAME BEHAVIOR IN JAVA AND C#
            // The class can access inherited protected field...            
            System.Console.WriteLine(someProtectedFiled);

            // DIFFERENT BEHAVIOR IN JAVA AND C#!
            // For the below to work (instead of CS1540 compilation error) the field would 
            // have to be public or protected internal because access is through qualifier
            // of type Base instead of Derived:
            // System.Console.WriteLine(new Base().someProtectedFiled);          
        }
    }
}

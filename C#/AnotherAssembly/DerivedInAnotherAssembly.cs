using Protected;

namespace DerivedInAnotherAssembly // Namespace doesn't matter
{
    public class Derived : Base
    {
        public void TestAccessInDerivedClassFromAnotherAssembly()
        {
            // SAME BEHAVIOR IN JAVA AND C#
            // The class can access inherited protected field even from another assembly            
            System.Console.WriteLine(someProtectedFiled);

            // SAME BEHAVIOR IN JAVA AND C#
            // For the below to work (instead of CS1540 compilation error) the field would have to be public:
            // System.Console.WriteLine(new Base().someProtectedFiled);           
        }
    }
}

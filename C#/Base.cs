namespace Protected
{
    public class Base
    {
        protected int someProtectedFiled = 123;

        public void TestAccessInBaseClass()
        {
            // SAME BEHAVIOR IN JAVA AND C#
            // The class can access its own protected field...            
            System.Console.WriteLine(someProtectedFiled);
        }
    }
}

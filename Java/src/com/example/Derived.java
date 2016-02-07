package com.example;

public class Derived extends Base {
    public void testAccessInDerivedClass() {
        // SAME BEHAVIOR IN JAVA AND C#
        // The class can access inherited protected field
        System.out.println(someProtectedFiled);

        // DIFFERENT BEHAVIOR IN JAVA AND C#!
        // Access to protected field is possible because classes are in the same package
        System.out.println(new Base().someProtectedFiled);
        // In C# the field would have to be public or protected internal (otherwise CS1540 error is produced)
    }
}

package com.example;

public class NotDerived {
    public void testAccessInNotDerivedClass() {
        // DIFFERENT BEHAVIOR IN JAVA AND C#!
        // Access to protected field is possible because classes are in the same package
        System.out.println(new Base().someProtectedFiled);
        // In C# the field would have to be public or protected internal (otherwise CS0122 error is produced)
    }
}

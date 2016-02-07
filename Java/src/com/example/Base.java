package com.example;

public class Base {
    protected int someProtectedFiled = 123;

    public void testAccessInBaseClass() {
        // SAME BEHAVIOR IN JAVA AND C#
        // The class can access its own protected field
        System.out.println(someProtectedFiled);
    }
}

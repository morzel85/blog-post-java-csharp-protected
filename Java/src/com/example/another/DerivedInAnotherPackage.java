package com.example.another;

import com.example.Base;

public class DerivedInAnotherPackage extends Base {
    public void testAccessInDerivedClassFromAnotherPackage() {
        // SAME BEHAVIOR IN JAVA AND C#
        // The class can access inherited protected field even from another package
        System.out.println(someProtectedFiled);

        // SAME BEHAVIOR IN JAVA AND C#
        // For the below to work (instead of compilation error) the field would have to be public:
        // System.out.println(new Base().someProtectedFiled);
    }
}

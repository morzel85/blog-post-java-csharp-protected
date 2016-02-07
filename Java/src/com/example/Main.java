package com.example;

import com.example.another.DerivedInAnotherPackage;

public class Main {
    public static void main(String[] args) {
        new Base().testAccessInBaseClass();
        new Derived().testAccessInDerivedClass();
        new NotDerived().testAccessInNotDerivedClass();
        new DerivedInAnotherPackage().testAccessInDerivedClassFromAnotherPackage();
    }
}

﻿namespace MakingMethodCallsSimpler.ReplaceConstructorwithFactoryMethod
{
    public class Employee
    {
        private int _type;
        static int ENGINEER = 0;
        static int SALESMAN = 1;
        static int MANAGER = 2;

        public Employee(int type)
        {
            _type = type;
        }
    }
}
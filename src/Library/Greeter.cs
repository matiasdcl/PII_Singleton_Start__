﻿using System;

namespace Library
{
    public class Greeter
    {
        public Greeter()
        {
            // Intentionally left blank
        }

        public static Greeter instance;

        public static Greeter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Greeter();
                }

                return instance;
            }
        }

        public void SayHiToTheWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
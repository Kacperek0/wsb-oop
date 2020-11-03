using System;
namespace OOP_lab2
{
    public class StaticTest
    {
        public StaticTest()
        {
            public static int StaticField = 1;

            public static int StaticProperty
            {
                get
                {
                    return StaticField;
                }

                set
                {
                    StaticField = value;
                }
            }

            public static void StaticMethod()
            {
                StaticTest.StaticField = 1;
            }

        }
    }
}





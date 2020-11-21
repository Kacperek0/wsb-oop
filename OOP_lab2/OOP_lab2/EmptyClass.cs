using System;
namespace OOP_lab2
{
    public class NonWritableTest
    {
        public readonly int nonWritableField = 1;
        public int NonWritableField
        {
            get
            {
                return nonWritableField;
            }
        }

    }
}

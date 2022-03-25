using System;

namespace findMaximum

{
    public class MaximumDoubleCheck
    {
        public static double MaxFloatNumber(double first, double second, double third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(second) > 0 && second.CompareTo(third) > 0)

            {
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            throw new Exception("first,second,third are same");
        }
    }
}

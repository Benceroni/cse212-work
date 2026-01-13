public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // okay sure bud

        // define an array to store the values

        // create for loop, iterating "length" number of times

        // inside said for loop, during each iteration, multiply "number" by i (iteration)+1 and appending that value to a list 

        // when done looping, return said array or list or whatever I'm still figuring out the difference in c#

        //I'm trying to work with a double[] array constructor and it's incredibly irritating.



        // double[] multiples_array = new double[length];

        List<double> multiples_array = new List<double>();



        for (var i = 0; i < length; i++)
        {
            // Console.WriteLine(i);
            double _number_to_append = number * (i + 1);
            Console.WriteLine(_number_to_append);
            multiples_array.Add(_number_to_append);
        }





        double[] stupid_double_type = multiples_array.ToArray();

        return stupid_double_type;

        // I'm very displeased with having to return the double[] type and not recieving any pointers in the materials. I had a lot of trouble finding documentation.
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.



        // I don't know how to do this elegantly so I will brute force it
        // this didn't work
        //// take total data length and subtract the offset

        //// use the negative value of this offset as the starting point to iterate through the list

        //// int index_offset = data.Count - amount;

        // I will now do as the hint suggests

        // take original data, split in two at "amount" point
        // to do this, create two array variables from the data

        // combine these two arrays

        // data = arrays_combined;

        List<int> first_half = data.GetRange(0, data.Count - amount);
        List<int> second_half = data.GetRange(data.Count - amount, amount);

        // Console.WriteLine("{0}", string.Join(", ", first_half));
        // Console.WriteLine("{0}", string.Join(", ", second_half));


        second_half.AddRange(first_half);

        // data = second_half;

        Console.WriteLine("data before is " + "[{0}]", string.Join(", ", data));


        for (var i = 0; i < data.Count; i++)
        {
            data.Insert(i,second_half[i]);
        }

        Console.WriteLine("data is " + "[{0}]", string.Join(", ", data));
        Console.WriteLine("second_half is " + "[{0}]", string.Join(", ", second_half));




    }
}

public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        // foreach value in selector list
        // decide if first or second list gets selected next
        // pull next value from that list and add to array
        // remove the value that was just used, or move the index of the "next value to pull"

        var first_index = 0;
        var second_index = 0;

        int[] list = { };
        
        foreach (int _value in select)
        {
            Console.WriteLine(_value);
            if (_value == 1)
            {
                list.Append(list1[first_index]);
                first_index += 1;
            }
            else
            {
                list.Append(list2[second_index]);
                second_index += 1;
            }
        }

        return list;
    }
}
using System;

int[] a = new int[] { -2, -1, 5 };
var c = Kata.CountSel(a);
foreach (var i in c)
{
    Console.WriteLine(i);
}
public class Kata
{
    public static object[] CountSel(int[] lst)
    {
        var list = new HashSet<int>();
        var setDifferentValues = new HashSet<int>();
        int totalNumber = lst.Length;
        int differentValues = 0;
        int onlyMeetOnce = 0;
        int maximumOccurrence = 0;
        for (int i = 0; i < lst.Length; i++)
        {
            int counter = 0;
            for (int j = 0; j < lst.Length; j++)
            {
                if (lst[i] == lst[j])
                {
                    counter++;
                    if (counter > maximumOccurrence)
                    {
                        maximumOccurrence = counter;
                    }
                }
            }
        }
        for (int i = 0; i < lst.Length; i++)
        {
            int counter = 0;
            setDifferentValues.Add(lst[i]);
            for (int j = 0; j < lst.Length; j++)
            {
                if (lst[i] == lst[j])
                {
                    counter++;
                    if (counter == maximumOccurrence)
                    {
                        list.Add(lst[i]);
                    }
                }

            }
            if (counter < 2)
            {
                onlyMeetOnce++;
            }

        }
        totalNumber = lst.Length;
        differentValues = setDifferentValues.Count;
        return new object[] { $"{totalNumber},{differentValues},{onlyMeetOnce},[[{String.Join(",", list)}], {maximumOccurrence}]"};
    }
}
namespace McCabe;

public static class McCabe
{
    public static void SumPositiveNumbers(int A, int B, int C, out int S, out int N)
    {
        int sum = 0;
        int count = 0;

        int[] temp = { A, B, C };

        foreach (int number in temp)
            if (number > 0)
            {
                sum += number;
                count++;
            }

        S = sum;
        N = count;
    }
}

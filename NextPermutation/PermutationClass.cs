namespace NextPermutation;
public class PermutationClass
{
    public void GetNextPermutation(int[] numsArray){
        var swap = PermutacionPost(numsArray);

        if (swap.Item1 != -1)
        {
            Swaping(swap, numsArray);
            Array.Sort(numsArray, swap.Item2 + 1, numsArray.Length - (swap.Item2 + 1));
        }
        else
            Array.Reverse(numsArray);
    }

    public static (int, int) PermutacionPost(int[] arrayNums)
    {
        int dif = int.MaxValue, sel = -1, tar = -1;
        for (int i = arrayNums.Length - 1; i > tar; i--)
            for (int j = i - 1; j >= 0; j--)
                if (arrayNums[i] > arrayNums[j] && i - j < dif)
                    if (sel == -1 || (arrayNums[sel] > arrayNums[i] || j > tar))
                    {
                        sel = i;
                        tar = j;
                        dif = i - j;
                        break;
                    }
        return (sel, tar);
    }

    public static void Swaping((int, int) positions, int[] arrayNums)
    {
        int t = arrayNums[positions.Item1];
        arrayNums[positions.Item1] = arrayNums[positions.Item2];
        arrayNums[positions.Item2] = t;
    }
}

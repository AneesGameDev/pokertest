using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public enum CardValues { two, three, four, five, six, seven, eight, nine, ten, jack, queen, king, ace };
public enum CardColors { hearts, diamonds, spades, clubs }*/
public static class ShuffleCards 
{
    // Start is called before the first frame update

    private static System.Random rng = new System.Random();

    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
    // Update is called once per frame
  
}

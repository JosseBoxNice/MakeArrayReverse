using System;

/// @author vesal
/// @version 28.8.2014
public class Tauno6
{
    public static void Main()
    {
        int[] t = { 23, 45, 12, 9, 3, 7 };
        Console.WriteLine("Aluksi : " + string.Join(", ", t));
        KaannaTaulukko(t);
        Console.WriteLine("Lopuksi: " + string.Join(", ", t));
    }


    /// <summary>
    /// Aliohjelmalla käännetään taulukko päinvastaiseen järjestykseen
    /// </summary>
    /// <param name="t">Käännettävä taulukko</param>
    /// <example>
    /// <pre name="test">
    ///  int[] t;
    ///  t = new int[]{$t1}; KaannaTaulukko(t); String.Join(", ",t) === "$t2";
    ///
    ///  $t1                |   $t2
    /// ------------------------------------------------
    ///     55, 44, 33, 2, 5, 9 | 9, 5, 2, 33, 44, 55
    ///     23, 45, 12, 9, 3, 7 | 7, 3, 9, 12, 45, 23
    /// </pre>
    /// </example>
    public static void KaannaTaulukko(int[] t)
    {
        // BYCODEBEGIN
        /*
        int i = 0;
        int j = 1;
        int muisti;
        muisti = t[j];
        t[j] = t[i];
        t[i] = muisti;
        j += 1;
        i += 1;
        muisti = t[j];
        t[j] = t[i];
        t[i] = muisti;
        j += 1;
        i += 1;
        muisti = t[j];
        t[j] = t[i];
        t[i] = muisti;
        j += 1;
        i += 1;
        muisti = t[j];
        t[j] = t[i];
        t[i] = muisti;
        j += 1;
        i += 1;
        muisti = t[j];
        t[j] = t[i];
        t[i] = muisti;
        */
        int p = 0;
        for (int n = 0; n < t.Length; n++)
        {
            int i = 0;
            int j = 1;
            int muisti;
            for (int a = 1; a < (t.Length - p); a++)
            {
                muisti = t[j];
                t[j] = t[i];
                t[i] = muisti;
                j += 1;
                i += 1;
            }
            p += 1;
        }
        // BYCODEEND
    }


}
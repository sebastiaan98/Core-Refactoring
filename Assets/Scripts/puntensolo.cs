using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class puntensolo : MonoBehaviour {
    public int puntenp1 = 0;
    public Text puntenP1tekst;

    public void AddPoints(int punten, int player)
    {
        if (player == 1)
        {
            puntenp1 += punten;
            puntenP1tekst.text = puntenp1.ToString();
        } else if(player == 2)
        {
            puntenp1 += punten;
            puntenP1tekst.text = puntenp1.ToString();
        }

    }
}

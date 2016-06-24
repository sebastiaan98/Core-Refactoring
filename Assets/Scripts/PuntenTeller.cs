using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PuntenTeller : MonoBehaviour
{
    public int puntenp1 = 0;
    public int puntenp2 = 0;
    public Text puntenP1tekst;
    public Text puntenP2tekst;
    public bool pvp
        ;
    public void AddPoints(int punten, int player)
    {
        if (pvp)
        {
            if (player == 1)
            {
                puntenp1 += punten;
                puntenP1tekst.text = "Blue: " + puntenp1.ToString();
            }
            else
            {
                puntenp2 += punten;
                puntenP2tekst.text = "Red: " + puntenp2.ToString();
            }
        }
        else
        {
            if (player == 1)
            {
                puntenp1 += punten;
                puntenP1tekst.text = puntenp1.ToString();
            }
            else
            {
                puntenp1 += punten;
                puntenP1tekst.text = puntenp1.ToString();
            }
        }
    }
}

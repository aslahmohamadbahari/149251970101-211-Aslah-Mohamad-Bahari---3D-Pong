using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerGO : MonoBehaviour
{
    bool merah = true,
             orange = true,
             pink = true,
             biru = true;

    [SerializeField] GameObject GMerah, GOrange, 
                                GPink,  GBiru;

    public int winnerCondition;

    private void Update()
    {
        if (winnerCondition == 3)
        {
            if (merah)
            {
                StaticVarWinner.Winner = "MERAH";
            }
            if (orange)
            {
                StaticVarWinner.Winner = "ORANGE";
            }
            if (pink)
            {
                StaticVarWinner.Winner = "PINK";
            }
            if (biru)
            {
                StaticVarWinner.Winner = "BIRU";
            }
        }
    }
    public void conditionMerah()
    {
        winnerCondition += 1;
        merah = false;
        Time.timeScale = 0;
    }

    public void conditioOrange()
    {
        winnerCondition += 1;
        orange = false;
        Time.timeScale = 0;
    }

    public void conditionPink()
    {
        winnerCondition += 1;
        pink = false;
        Time.timeScale = 0;
    }

    public void conditionBiru()
    {
        winnerCondition += 1;
        biru = false;
        Time.timeScale = 0;
    }
}

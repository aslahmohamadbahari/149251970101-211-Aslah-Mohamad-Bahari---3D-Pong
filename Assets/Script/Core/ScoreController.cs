using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text skorMerah;
    public Text skorOrange;
    public Text skorPink;
    public Text skorBiru;

    public ScoreManager Manager;

    // Update is called once per frame
    void Update()
    {
        skorMerah.text = Manager.scoreMerah.ToString();
        skorOrange.text = Manager.scoreOrange.ToString();
        skorPink.text = Manager.scorePink.ToString();
        skorBiru.text = Manager.scoreBiru.ToString();
    }
}

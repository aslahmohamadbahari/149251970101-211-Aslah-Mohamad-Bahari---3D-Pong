using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TriggerGO CW;

    [Header ("Setting Score")]
    public int scoreMerah;
    public int scoreOrange;
    public int scorePink;
    public int scoreBiru;
    public int maxScore;

    [Header("Wall")]
    [SerializeField] GameObject WallMerah;
    [SerializeField] GameObject WallOrange;
    [SerializeField] GameObject WallPink;
    [SerializeField] GameObject WallBiru;

    [Header("Player")]
    [SerializeField] GameObject PlayerMerah;
    [SerializeField] GameObject PlayerOrange;
    [SerializeField] GameObject PlayerPink;
    [SerializeField] GameObject PlayerBiru;

    [Header("LoseScren")]
    [SerializeField] GameObject gameOverUI;

    public void addOrangeScore(int increment)
    {
        scoreOrange += increment;
        if (scoreOrange == maxScore)
        {
            WallOrange.SetActive(true);
            PlayerOrange.SetActive(false);
            CW.conditionMerah();
        }

    }

    public void addMerahScore(int increment)
    {
        scoreMerah += increment;
        if (scoreMerah == maxScore)
        {
            WallMerah.SetActive(true);
            PlayerMerah.SetActive(false);
            CW.conditioOrange();
            gameOverUI.SetActive(true);
            Destroy(gameObject);
        }
    }

    public void addPinkScore(int increment)
    {
        scorePink += increment;
        if (scorePink == maxScore)
        {
            WallPink.SetActive(true);
            PlayerPink.SetActive(false);
            CW.conditionPink();
            gameOverUI.SetActive(true);
            Destroy(gameObject);
        }
    } 

    public void addBiruScore(int increment)
    {
        scoreBiru += increment;
        if (scoreBiru == maxScore)
        {
            WallBiru.SetActive(true);
            PlayerBiru.SetActive(false);
            CW.conditionBiru();
            gameOverUI.SetActive(true);
            Destroy(gameObject);
        }
    }
}

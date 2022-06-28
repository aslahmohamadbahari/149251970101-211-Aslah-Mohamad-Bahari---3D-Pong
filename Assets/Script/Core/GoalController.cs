using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalController : MonoBehaviour
{
    public ScoreManager Manager;

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Merah"))
        {
            Manager.addMerahScore(1);
        }

        if (gameObject.CompareTag("Orange"))
        {
            Manager.addOrangeScore(1);
        }

        if (gameObject.CompareTag("Pink"))
        {
            Manager.addPinkScore(1);
        }

        if (gameObject.CompareTag("Biru"))
        {
            Manager.addBiruScore(1);
        }
    }
}

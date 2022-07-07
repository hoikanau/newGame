using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class gameMaster : MonoBehaviour
{
    public float score;
    public GameObject WinScreen;


    public void scored()
    {
        score++;
        Debug.Log(score);
        if(score == 5)
        {
            Debug.Log("You win! Score reseting");
            WinScreen.SetActive(true);
            score = 0;
        }
    }
}

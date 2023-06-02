using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreBoard : MonoBehaviour
{
    int score;
    TMP_Text scoretext;
    void Start()
    {
        scoretext = GetComponent<TMP_Text>();
        scoretext.text = "Start";
    }

    public void IncreaseScore(int amounToIncrease)
    {
        score += amounToIncrease;
        scoretext.text = score.ToString();
    }





}

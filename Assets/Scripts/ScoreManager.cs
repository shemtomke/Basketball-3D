using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreUI;
    public int score = 0;
    public int targetScore = 2;

    private void Update()
    {
        scoreUI.text = "" + score;
    }
    public int AddScore()
    {
        return score++;
    }
}

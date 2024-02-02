using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int currentLevel = 1;
    public int chances = 4;
    public int currentChance = 0;

    ScoreManager scoreManager;
    GameManager gameManager;
    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        gameManager = FindObjectOfType<GameManager>();
    }
    private void Update()
    {
        ChancesStatus();
    }
    // i.e to proceed to Level 2 -> 5 Chances - Score 3 only 
    void ChancesStatus()
    {
        if(currentChance == chances)
        {
            if(scoreManager.score >= scoreManager.targetScore)
            {
                // Win Game

            }
            else
            {
                // Game Over -> Play Ads to Get Additional Chances

            }
        }
    }
    void LevelUpdate() // Save in Firebase
    {
        // Level 1 - 4 chances - targetscore 2
        currentLevel += 1;
        chances += 4;
        scoreManager.targetScore += 2;
    }
}

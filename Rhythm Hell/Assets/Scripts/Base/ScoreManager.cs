using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public int currentGameScore = 0;

    public int scorePerNote = 100;

    public int scoreMultiplier;

    public TextMeshProUGUI gameScoreText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void incrementGameScore(bool isNoteHit)
    {
        if (isNoteHit)
        {
            currentGameScore += scorePerNote;
        }
        else 
        {
            scoreMultiplier = 1;
            // currentGameScore -= scorePerNote;
        }
        
        gameScoreText.text = "Score: " + currentGameScore.ToString();
    }



}

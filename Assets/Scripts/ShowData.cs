using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    public Text PlayerNameText;
    public Text currentScoreText;
    public Text highScoreText;

    private void Awake()
    {
        {
            PlayerNameText.text = "Name: " +
                keepData.PlayerName;
            currentScoreText.text = "Last score: " +
                keepData.Currentscore;
            highScoreText.text = "High score: " +
                keepData.HighScore;
            keepData.Currentscore = 0;
        }
    }

}

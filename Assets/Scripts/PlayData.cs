using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayData : MonoBehaviour
{
    public Text nameText;
    public Text currentScoreText;
    public Text highScoreText;
    public Text ballSpeedText;
    public Text targetRotationSpeedText;
    public Text oversizedBallText;
    public Slider ballSpeedMultiplierSlider;
    public Slider targetRotationSpeedSlider;

    private void Awake()
    {
        nameText.text = "Name: " + keepData.PlayerName;
        currentScoreText.text = "Score: " + keepData.Currentscore;
        highScoreText.text = "High: " + keepData.HighScore;
        ballSpeedText.text = "Ball Speed: " + keepData.PlayerSpeedMultiplier;
        targetRotationSpeedText.text = "Target: " + keepData.TargetRotationSpeedMultiplier;
        oversizedBallText.text = "Large ball: " + keepData.OversizedBall;
        ballSpeedMultiplierSlider.value = keepData.PlayerSpeedMultiplier;
        targetRotationSpeedSlider.value = keepData.TargetRotationSpeedMultiplier;
    }

    private void Update()
    {
        nameText.text = "Name: " + keepData.PlayerName;
        currentScoreText.text = "Score: " + keepData.Currentscore;
        highScoreText.text = "High: " + keepData.HighScore;
        ballSpeedText.text = "Ball Speed: " + keepData.PlayerSpeedMultiplier;
        targetRotationSpeedText.text = "Target: " + keepData.TargetRotationSpeedMultiplier;
        oversizedBallText.text = "Large ball: " + keepData.OversizedBall;
        ballSpeedMultiplierSlider.value = keepData.PlayerSpeedMultiplier;
        targetRotationSpeedSlider.value = keepData.TargetRotationSpeedMultiplier;
    }
}

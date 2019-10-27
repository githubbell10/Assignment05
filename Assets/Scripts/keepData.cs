using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keepData : MonoBehaviour
{
    public static string PlayerName = "default name";
    public static bool OversizedBall = true;
    public static int RoundsToPlay =3;
    public static float PlayerSpeedMultiplier = 1.0f;
    public static int Currentscore = 0;
    public static int HighScore = 0;
    public static int TargetRotationSpeedMultiplier;


    public InputField playerName;
    public Toggle ballSize;
    public Dropdown roundsToPlay;
    public Slider playerSpeedMultiplier;
    public Slider targetRotationSlider;
    

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateName()    //updates on input change for input field
    {
        PlayerName = playerName.text;
    }
    public void BigBall (bool newValue)
    {
        OversizedBall = newValue;
    }

    
    
    public void SetRoundsToPlay()
    {
        switch (roundsToPlay.value)
        {
            case 1:
                RoundsToPlay = 1;
                break;
            case 2:
                RoundsToPlay = 2;
                break;
            case 3:
                RoundsToPlay = 3;
                break;
            case 4:
                RoundsToPlay = 4;
                break;
            default:
                RoundsToPlay = 1;
                break;
        }
    }
    public void SetPlayerSpeedMultiplier()
    {
        PlayerSpeedMultiplier = playerSpeedMultiplier.value;    // value of the slider
    }
}
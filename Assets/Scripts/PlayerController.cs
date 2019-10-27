using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       // Required to use "Text" object and other UI elements
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public AudioSource impactSound;
    public float speed = 800.0f;    // public so we can change this value in the inspector
    public Text winText;
    public Text scoreText;
    public Text playernameText;
    public Text highScoreText;

    private void Awake()
    {
        
        if (keepData.OversizedBall)
        {
            this.gameObject.transform.localScale = new Vector3(3.0f, 3.0f, 3.0f);
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
        
    }
    private void FixedUpdate()          // Infinite loop while we are in play mode
    {
        float moveHorizontal = Input.GetAxis("Horizontal");   // Left-Right input stored as a float between -1.0 and 1.0
        float moveVertical = Input.GetAxis("Vertical");       // Down-Up input stored as a float between -1.0 and 1.0

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);     // Direction of the sum of both input values

        GetComponent<Rigidbody>().AddForce(movement * speed * keepData.PlayerSpeedMultiplier * Time.deltaTime);  // Applies force in desired direction
        playernameText.text = keepData.PlayerName;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")       // If the object that was entered has the tag "Pickup"
        {
            impactSound.Play();
            other.gameObject.SetActive(false);      // Then set that object to be inactive (hide it)
            keepData.Currentscore += 1;
            scoreText.text = "Score: " + keepData.Currentscore;     // Updates the text property of scoreText
            if (keepData.Currentscore > keepData.HighScore)
            {
                keepData.HighScore = keepData.Currentscore;
            }
            if (keepData.Currentscore % 20 == 0 && keepData.RoundsToPlay >0)
            {
                winText.gameObject.SetActive(true);
                winText.text = "You got them all";
                keepData.RoundsToPlay -= 1;
               SceneManager.LoadScene("MainScene");
            }

            }

       // scoreText.text = keepData.PlayerName + ": " + keepData.Currentscore + "(Highscore : " + keepData.HighScore + ")";
    }
}

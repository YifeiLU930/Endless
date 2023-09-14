using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public Text scoreText;
    int score;

    private void start()
    {
        scoreText.text = PlayerPrefs.GetInt("Score").ToString();
        score = PlayerPrefs.GetInt("Score");
    }

    public void scoreUpdate()
    {
       

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {

            score++;
            scoreText.text = score.ToString();
            PlayerPrefs.SetInt("Score", score);
        }
    }



   



}

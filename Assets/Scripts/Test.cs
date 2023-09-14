using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public AudioSource audioPlayer;
    public Scoring score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {
            audioPlayer.Play();
            score.AddScore(1) ;
            
        }
    }


}

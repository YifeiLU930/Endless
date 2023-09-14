using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    public AudioSource audioPlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
           
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }
    }

   


}
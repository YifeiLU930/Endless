using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
   

    private void OnTriggerEnter(Collider other)
    {

        PlayerManager.numberOfCoins++;
        PlayerPrefs.SetInt("NumberOfCoins", PlayerManager.numberOfCoins);
        Destroy(gameObject);
    }
}
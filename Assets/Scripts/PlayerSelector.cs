using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelector : MonoBehaviour
{
    public GameObject[] playerSkins;
    int selectedBall;

    public Unlock[] balls;
    public Button[] buttons;

    public Button unlockButton;

    private void Awake()
    {
        int counter = 0;
        foreach (Unlock b in balls)
        {
            b.index = counter;
            if (counter == 0)
                b.isLocked = false;
            else
            {
                if (PlayerPrefs.GetInt(b.index.ToString(), 1) == 1)
                    b.isLocked = true;
                else
                    b.isLocked = false;
                buttons[b.index].interactable = !b.isLocked;




            }

            counter++;

        }
    }

    
    // Start is called before the first frame update
    void Start()
    {
        selectedBall = PlayerPrefs.GetInt("SelectedBall", 0);
        foreach(GameObject skin in playerSkins)
        {
            skin.SetActive(false);
        }
        playerSkins[selectedBall].SetActive(true);
       
    }

 
    private void Update()
    {
        if (PlayerPrefs.GetInt("NumberOfCoins", 0) < 10)
            unlockButton.interactable = false;
        else
            unlockButton.interactable = true;


    }


    
     
    
    
    
    public void ChangePlayer(int index)
    {
        playerSkins[selectedBall].SetActive(false);
        selectedBall = index;
        playerSkins[selectedBall].SetActive(true);
        PlayerPrefs.SetInt("SelectedBall", index);
    }


    public void Unlock1()
    {
        //Get the Locked Balls
        List<Unlock> lockedBalls = new List<Unlock>();
        foreach(Unlock b in balls)
        {
            if(b.isLocked)
                lockedBalls.Add(b);
        }

        if (lockedBalls.Count == 0)
            return;



        //Select a Random Ball
        int randomBall = Random.Range(0, lockedBalls.Count);

        //Unlock the Ball
        int ballIndex = lockedBalls[randomBall].index;
        balls[ballIndex].isLocked = false;
        buttons[ballIndex].interactable = true;
        PlayerPrefs.SetInt(ballIndex.ToString(), 0);
        PlayerPrefs.SetInt("NumberOfCoins", PlayerPrefs.GetInt("NumberOfCoins") - 10);

        //Select Ball
        buttons[ballIndex].onClick.Invoke();

        



   
    
    
    
    
    
    
    
    }



 
}

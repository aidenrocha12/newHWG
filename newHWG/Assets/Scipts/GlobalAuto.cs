using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAuto : MonoBehaviour
{
   
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int runnerValue = 10;
    public static bool turnOffButton = false;
    public GameObject runnerStats;
    public static int numberOfRunners;
    public static int runnerPerSec;
    

    
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        runnerStats.GetComponent<Text>().text = "Hamsters: " + numberOfRunners + " @ " + runnerPerSec + " Per Second";
        fakeText.GetComponent<Text>().text = "Buy Runner $" + runnerValue;
        realText.GetComponent<Text>().text = "Buy Runner $" + runnerValue;
        if (currentCash >= runnerValue) {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (turnOffButton == true){
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}

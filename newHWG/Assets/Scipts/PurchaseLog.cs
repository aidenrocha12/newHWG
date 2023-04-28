using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoWatts;
    public AudioSource playSound;

    public void StartAutoWatt(){
        AutoWatts.SetActive(true);
        
        playSound.Play();
        GlobalCash.CashCount -= GlobalAuto.runnerValue;
        GlobalAuto.runnerValue *= 2;
        GlobalAuto.turnOffButton = true;
        GlobalAuto.runnerPerSec += 1;
        GlobalAuto.numberOfRunners +=1;
    }
}

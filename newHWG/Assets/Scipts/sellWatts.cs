using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sellWatts : MonoBehaviour
{
    public GameObject textBox;
    public GameObject statusBox;
    public AudioSource cashOne;
    public AudioSource cashTwo;
    public int generateTone;

    
    public void ClickButton() {
        generateTone = Random.Range(1,3);

        if (GlobalWatts.WattCount == 0)
        {
            statusBox.GetComponent<Text>().text = " Not enough watts to sell.";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else {
        if(generateTone ==1){
            cashOne.Play();
        }
        if(generateTone ==2){
            cashTwo.Play();
        }
        GlobalWatts.WattCount -= 1;
        GlobalCash.CashCount += 1;
        }
    }
}

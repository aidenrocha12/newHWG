using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sellWatts : MonoBehaviour
{
    public GameObject textBox;
    public GameObject statusBox;
    
    public void ClickButton() {

        if (GlobalWatts.WattCount == 0)
        {
            statusBox.GetComponent<Text>().text = " Not enough watts to sell.";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else {

        GlobalWatts.WattCount -= 1;
        GlobalCash.CashCount += 1;
        }
    }
}

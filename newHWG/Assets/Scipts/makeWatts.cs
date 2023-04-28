using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeWatts : MonoBehaviour
{
    public GameObject textBox;
    
    public void ClickButton() {
        GlobalWatts.WattCount += 1;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalWatts : MonoBehaviour
{
    public static int WattCount;
    public GameObject WattDisplay;
    public int InternalWatt;

    void Update()
    {
        InternalWatt = WattCount;
        WattDisplay.GetComponent<Text>().text = "Watts: " + InternalWatt;
    }
}

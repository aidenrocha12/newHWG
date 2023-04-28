using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoWatts;

    public void StartAutoWatt(){
        AutoWatts.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoWatts: MonoBehaviour
{
    public bool CreatingWatt = false;
    public static int WattIncrease = 1;
    public int InternalIncrease;

    void Update() {
        WattIncrease = GlobalAuto.runnerPerSec;
        InternalIncrease = WattIncrease;
        if (CreatingWatt == false){
            CreatingWatt = true;
            StartCoroutine(CreateTheWatt());
        }
        }

        IEnumerator CreateTheWatt () {
            GlobalWatts.WattCount += InternalIncrease;
            yield return new WaitForSeconds(1);
            CreatingWatt = false;
        }
    }
    
    


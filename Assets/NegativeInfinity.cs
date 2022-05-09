using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NegativeInfinity : MonoBehaviour
{ // Prints number of fingers touching the screen
    void Update()
    {
        var fingerCount = 0;
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
            {
                fingerCount++;
            }
        }
        if (fingerCount > 1)
        {
            print("User has " + fingerCount + " finger(s) touching the screen");
            transform.Translate(0,0,fingerCount);
        }
    }
}

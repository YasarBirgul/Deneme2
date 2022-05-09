using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAxis : MonoBehaviour
{
    // Update is called once per frame
     float horizontalSpeed =  1.0f;
        float verticalSpeed = 1.0f;

        void Update()
        { 
            // Get the mouse delta. This is not in the range -1...1
            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            float v = verticalSpeed * Input.GetAxis("Mouse Y");
            transform.Rotate(v, h, 0);
        }
        
    
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.Experimental.TerrainAPI;

public class Normalise : MonoBehaviour
{
    public Vector3 dir;
   
   // Start is called before the first frame update


   private void Update()
   {
     

   }

   // Update is called once per frame
    void FixedUpdate()
    {
               float moveH = Input.GetAxisRaw("Horizontal");
               float moveV = Input.GetAxisRaw("Vertical");
                dir = new Vector3(moveH, 0, moveV);
                dir.Normalize();
                transform.position = dir*10f;
      
    }
}

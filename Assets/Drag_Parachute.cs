using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag_Parachute : MonoBehaviour
{
    
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OpenParachute()
    {
        rb.drag = 6;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            OpenParachute();
        
    }
    }
    


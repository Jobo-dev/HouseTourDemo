using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class salto : MonoBehaviour
{
                    
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public float jumpForce = 3f;
    Rigidbody rb;
    
    bool salta = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    public void jump()
    {
        salta = true;

    }


    // Update is called once per frame
    void Update()
    {
        
              
        if (salta)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            salta = false;
                        
        }

    }
}

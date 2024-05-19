using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FpmMovementYomero : MonoBehaviour
{
    public CharacterController controller;
    
    public float speed = 3f;
    float gravity = -9.81f;
    public float jumpHeight = 1f;

    public Transform groundCheck;
    float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    //para cuando se tiene un boton de movimeinto
    public Joystick joystick;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        //para cuando se utilizan botones
        /*float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");*/

        //para cuando se utiliza touch
        float x = joystick.Horizontal;
        float z = joystick.Vertical;

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        
        if(Input.GetButtonDown("Jump") && isGrounded){
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        //caida libre o gravedad
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}

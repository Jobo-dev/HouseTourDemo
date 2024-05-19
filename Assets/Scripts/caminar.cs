using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class caminar : MonoBehaviour
{
    //antes solo era clase Joystick
    public FixedJoystick joystick;
    public float speed = 3f;
    
    Vector2 velocity;
    

    private void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        //velocity.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //velocity.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        velocity.y = joystick.Vertical * speed * Time.deltaTime;
        velocity.x = joystick.Horizontal * speed * Time.deltaTime;
        transform.Translate(velocity.x, 0, velocity.y);
                
        
    }
}

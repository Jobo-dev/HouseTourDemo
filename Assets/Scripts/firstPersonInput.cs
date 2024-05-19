using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class firstPersonInput : MonoBehaviour
{
    
    public FloatingJoystick MoveJoystick;
    public bool button = false;
    public FloatingJoystick RotateJoystick;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void saltar()
    {
        button = true;

    }

    // Update is called once per frame
    void Update()
    {
        var fps = GetComponent<RigidbodyFirstPersonController>();
        fps.RunAxis = new Vector2(MoveJoystick.Horizontal,MoveJoystick.Vertical);
        fps.JumpAxis = button;
        button = false;
        fps.mouseLook.LookAxis = new Vector2(RotateJoystick.Horizontal, RotateJoystick.Vertical);


    }
}

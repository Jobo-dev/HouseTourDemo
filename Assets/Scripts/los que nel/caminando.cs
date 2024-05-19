using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caminando : MonoBehaviour
{
    public Transform player;
    public Joystick joystick;
    public float speed = 3f;
    float posX = 0f;
    float posZ = 0f;

    private void Start()
    {
        posX = player.position.x;
        posZ = player.position.z;
    }
    // Update is called once per frame
    void Update()
    {
        float x = joystick.Horizontal;
        float z = joystick.Vertical;
        if (x != 0 || z != 0)
        {
            posX = posX + (x * speed * Time.deltaTime);
            posZ = posZ + (z * speed * Time.deltaTime);
            player.position = new Vector3(posX, player.position.y, posZ);
        }

    }
}

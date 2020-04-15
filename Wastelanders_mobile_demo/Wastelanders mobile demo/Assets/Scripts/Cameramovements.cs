using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Cameramovements : MonoBehaviour
{
    public float speedH=0.8f;
    public float speedV=0.8f;
    private float yaw;
    private float pitch;
    public Joystick Lookjoystick;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        yaw -= speedH*Lookjoystick.Vertical;
        pitch += speedV * Lookjoystick.Horizontal;

        transform.eulerAngles = new Vector3(yaw,pitch,0.0f);
    }
}

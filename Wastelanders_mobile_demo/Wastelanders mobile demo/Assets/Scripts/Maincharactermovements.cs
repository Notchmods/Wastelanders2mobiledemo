using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maincharactermovements : MonoBehaviour
{
    public Joystick Joysticks;
    public Transform Maincamera;
    public CharacterController Bodymove;
    public AudioSource Land;
    public AudioSource Moving;
    public AudioSource Jump;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Put values in the variables
        float Horizontaljoysticks = Joysticks.Horizontal;
        float VerticalJoysticks = Joysticks.Vertical;
        Vector3 CamF = Maincamera.forward;
        Vector3 CamR = Maincamera.right;
        CamF.y = 0; 
        CamR.y = 0;
        //Detect the joysticks position and place it into a Vector3
        var DesiredMoveDirection = CamF * VerticalJoysticks + CamR * Horizontaljoysticks;
        //Move the joysticks 
        Bodymove.Move(DesiredMoveDirection * 35f * Time.deltaTime);
       
    }
    public void Jumping()
    {
        Bodymove.Move(Vector3.up * 10f);
        Jump.Play();
        Invoke("Godown", 0.2f);
    }

    public void Godown()
    {
        Bodymove.Move(Vector3.down *10f);
        Land.Play();
    }
}

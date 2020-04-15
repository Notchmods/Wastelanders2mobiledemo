using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PCmobilconvertscript : MonoBehaviour
{
    public FixedJoystick Movejoysticks;
    public FixedButton JumpButtons;
    public FixedTouchField Touchfield;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        RigidbodyFirstPersonController fps = GetComponent<RigidbodyFirstPersonController>();
        fps.mouseLook.Lookaxis = Touchfield.TouchDist;
        fps.Runaxis = Movejoysticks.Direction;
        fps.Jumpaxis = JumpButtons.pressed;
    }
}

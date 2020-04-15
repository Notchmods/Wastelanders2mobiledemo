using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIscript : MonoBehaviour
{
    public GameObject Players;
    public Animator Runninganimation;
    public bool Offbeforegame;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Offbeforegame == false)
        {
            transform.LookAt(Players.transform.position);
            Runninganimation.SetBool("Run", true);
            transform.Translate(Vector3.forward * 20f * Time.deltaTime);    
        }
    }
}

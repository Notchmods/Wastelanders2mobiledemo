using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballscript : MonoBehaviour
{
    public GameObject Playertarget;
    public float Speed;
    public bool Beforeactive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Look at player and chase player
        transform.LookAt(Playertarget.transform.position);
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
}

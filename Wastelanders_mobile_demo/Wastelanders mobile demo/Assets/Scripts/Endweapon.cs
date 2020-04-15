using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endweapon : MonoBehaviour
{
    public GameObject[] Thingstoturnon;
    public bool Switchtime;
    // Start is called before the first frame update
    void Start()
    {
        Switchtime = false;
    }

    public void OnEnable()
    {
        Switchtime = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Turn off the flame thrower and its controls and turn on AK 47 and its control 
         if(Switchtime == true)
        {
            Thingstoturnon[0].gameObject.SetActive(true);
            Thingstoturnon[1].gameObject.SetActive(true);
            Thingstoturnon[2].gameObject.SetActive(true);
            Thingstoturnon[5].gameObject.SetActive(true);
            Thingstoturnon[6].gameObject.SetActive(true);
            Thingstoturnon[3].gameObject.SetActive(false);
            Thingstoturnon[4].gameObject.SetActive(false);
        }
    }
}

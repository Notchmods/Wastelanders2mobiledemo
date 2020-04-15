using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunslevelUnlock : MonoBehaviour
{
    public Scorescript Scoreleveltounlock;
    public GameObject[] Gunsimageblocker;
    public bool Flamethroweroff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Compile the guns into a variable
        for(int i = 0; i < Gunsimageblocker.Length; i++)
        {
            //Set the gun to unlock at a specific level
            if(Scoreleveltounlock.Scores >= 45)
            {
                Gunsimageblocker[0].gameObject.SetActive(false);
            }
            if (Scoreleveltounlock.Scores >= 125)
            {
                Gunsimageblocker[1].gameObject.SetActive(false);
            }
            if (Scoreleveltounlock.Scores >= 205)
            {
                Gunsimageblocker[2].gameObject.SetActive(false);
            }
            if (Scoreleveltounlock.Scores >= 250)
            {
                if(Flamethroweroff == true)
                {
                    Gunsimageblocker[3].gameObject.SetActive(false);
                }
            }
            if (Scoreleveltounlock.Scores >= 500)
            {
                Gunsimageblocker[4].gameObject.SetActive(false);
            }
        }
    }
}

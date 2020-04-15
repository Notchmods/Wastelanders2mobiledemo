using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawnenemies : MonoBehaviour
{
    public GameObject[] Spawnpoints;
    public GameObject[] Deadenemies;
    public GameObject[] Balls;
    public Scorescript Timetillspawn;
    public bool Artillerytime;
    public Creepingbarrage Artilleryon;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Set artillery warning
        if (Timetillspawn.Scores == 100 || Timetillspawn.Scores == 480 || Timetillspawn.Scores == 520)
        {
            Spawnpoints[7].gameObject.SetActive(true);
            Spawnpoints[8].gameObject.SetActive(true);
            Spawnpoints[9].gameObject.SetActive(true);
            Spawnpoints[10].gameObject.SetActive(false);
            Spawnpoints[11].gameObject.SetActive(false);
        }
        if (Timetillspawn.Scores == 200 || Timetillspawn.Scores == 760|| Timetillspawn.Scores == 850|| Timetillspawn.Scores == 890|| Timetillspawn.Scores == 945)
            {
                Spawnpoints[7].gameObject.SetActive(true);
                Spawnpoints[8].gameObject.SetActive(true);
                Spawnpoints[9].gameObject.SetActive(true);
                Spawnpoints[10].gameObject.SetActive(false);
                Spawnpoints[11].gameObject.SetActive(false);
            }
            if (Timetillspawn.Scores == 350|| Timetillspawn.Scores == 565|| Timetillspawn.Scores == 610|| Timetillspawn.Scores == 690|| Timetillspawn.Scores == 720)
            {
                Spawnpoints[7].gameObject.SetActive(true);
                Spawnpoints[8].gameObject.SetActive(true);
                Spawnpoints[9].gameObject.SetActive(true);
                Spawnpoints[10].gameObject.SetActive(false);
                Spawnpoints[11].gameObject.SetActive(false);
            }
        if (Timetillspawn.Scores == 480)
        {
            Spawnpoints[7].gameObject.SetActive(true);
            Spawnpoints[8].gameObject.SetActive(true);
            Spawnpoints[9].gameObject.SetActive(true);
            Spawnpoints[10].gameObject.SetActive(false);
            Spawnpoints[11].gameObject.SetActive(false);
        }
        //Gather the spawnpoint into one variable
        for(int i = 0; i < Spawnpoints.Length; i++)
        {
            //Gather the Enemies into one variable
            for (int C = 0; C < Deadenemies.Length;C++)
            {
                if(Deadenemies[C].GetComponent<AIscript>().Offbeforegame == false)
                {
                    if (Deadenemies[C].activeInHierarchy == false)
                    {
                        //Spawn to random spawnpoints between 0,5
                        int respawnpos = Random.Range(0, 5);
                        //Set the Enemies to that spawnpoint position then set it active
                        Deadenemies[C].transform.position = Spawnpoints[respawnpos].transform.position;
                        Deadenemies[C].gameObject.SetActive(true);
                    }
                }
                //Set the enemies active when the player achieved enough kill
                if (Timetillspawn.Scores >= 10)
                {
                    if(Deadenemies[2].GetComponent<AIscript>().Offbeforegame == true)
                    {
                        Deadenemies[2].gameObject.SetActive(true);
                        Deadenemies[2].GetComponent<AIscript>().Offbeforegame = false;
                    }
                }
                if(Timetillspawn.Scores >=35){
                    if (Deadenemies[2].GetComponent<AIscript>().Offbeforegame == true)
                    {
                        Deadenemies[3].gameObject.SetActive(true);
                        Deadenemies[3].GetComponent<AIscript>().Offbeforegame = false;
                    }
                }
                if (Timetillspawn.Scores >= 55)
                {
                    if (Deadenemies[2].GetComponent<AIscript>().Offbeforegame == true)
                    {
                        Deadenemies[4].gameObject.SetActive(true);
                        Deadenemies[4].GetComponent<AIscript>().Offbeforegame = false;
                    }
                }
                if (Timetillspawn.Scores >= 85)
                {
                    if (Deadenemies[2].GetComponent<AIscript>().Offbeforegame == true)
                    {
                        Deadenemies[5].gameObject.SetActive(true);
                        Deadenemies[5].GetComponent<AIscript>().Offbeforegame = false;
                    }
                }
                if (Timetillspawn.Scores >= 165)
                {
                    if (Deadenemies[2].GetComponent<AIscript>().Offbeforegame == true)
                    {
                        Deadenemies[6].gameObject.SetActive(true);
                        Deadenemies[6].GetComponent<AIscript>().Offbeforegame = false;
                    }
                }
                if (Timetillspawn.Scores >= 230)
                {
                    if (Deadenemies[2].GetComponent<AIscript>().Offbeforegame == true)
                    {
                        Deadenemies[7].gameObject.SetActive(true);
                        Deadenemies[7].GetComponent<AIscript>().Offbeforegame = false;
                    }
                }
                if (Timetillspawn.Scores >= 300)
                {
                    if (Deadenemies[2].GetComponent<AIscript>().Offbeforegame == true)
                    {
                        Deadenemies[8].gameObject.SetActive(true);
                        Deadenemies[8].GetComponent<AIscript>().Offbeforegame = false;
                    }
                }
            }   
            for(int B = 0; B < Balls.Length; B++)
            {
                if(Balls[B].activeInHierarchy == false)
                {
                    if(Balls[B].GetComponent<Ballscript>().Beforeactive == false)
                    {
                        //Spawn to random spawnpoints between    0,5
                        int respawnpos = Random.Range(0, 5);
                        //Set the Balls to that spawnpoint position then set it active
                        Balls[B].transform.position = Spawnpoints[respawnpos].transform.position; 
                        Balls[B].gameObject.SetActive(true);
                    }
                }
                if(Timetillspawn.Scores >= 45)
                {
                    Balls[0].gameObject.SetActive(true);
                    Balls[0].GetComponent<Ballscript>().Beforeactive = false;
                }
                if(Timetillspawn.Scores >= 125)
                {
                    Balls[1].gameObject.SetActive(true);
                    Balls[1].GetComponent<Ballscript>().Beforeactive = false;
                }
                if (Timetillspawn.Scores >= 330)
                {
                    Balls[2].gameObject.SetActive(true);
                    Balls[2].GetComponent<Ballscript>().Beforeactive = false;
                }
                if (Timetillspawn.Scores >= 380)
                {
                    Balls[2].gameObject.SetActive(true);
                    Balls[2].GetComponent<Ballscript>().Beforeactive = false;
                }
            }
        }
    }

    public void Turnoffdialogue()
    {
        Timetillspawn.Scores += 1;
        Artilleryon.enabled = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Playershealth : MonoBehaviour
{
    public Text healthtxt;
    public float health { get; set; }
    public float Maxhealth { get; set; }
    public Scorescript Scoresave;
    public Slider playerhealthbar;  

    // Start is called before the first frame update
    void Start()
    {
        Maxhealth = 100f;
        health = Maxhealth;
        //Set the value of the healthbar
        playerhealthbar.value = Calculatehealth();
    }

    // Update is called once per frame
    void Update()
    {
        healthtxt.text = health.ToString();
        //Save scores
        //If health is less than one then die
        if(health <= 1)
        {
            Scoresave.Savescores();
            SceneManager.LoadScene(2);
        }
        //Set the value of the healthbar
        playerhealthbar.value = Calculatehealth();

    }

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //if the player hit a gameobject with the tag enemies
        // then they will lose 1 health
        if (hit.gameObject.tag == "Enemies")
        {
            health -= 1f;
            Debug.Log(health);
            //Set the value of the healthbar
            playerhealthbar.value = Calculatehealth();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        //if the player hit a gameobject with the tag enemies
        // then they will lose 1 health
        if (other.gameObject.tag == "Enemies")
        {
            health -= 1;
            Debug.Log(health);
            //Set the value of the healthbar
            playerhealthbar.value = Calculatehealth();
        }

        if(other.gameObject.tag == "Wastelandersballs")
        {
            SceneManager.LoadScene(2);
        }
    }
    public void Paused()
    {

        Time.timeScale = 0f;
    }

    public void Unpaused()
    {
        Time.timeScale = 1f;
    }

    public float Calculatehealth()
    {
        return health / Maxhealth;
    }
}

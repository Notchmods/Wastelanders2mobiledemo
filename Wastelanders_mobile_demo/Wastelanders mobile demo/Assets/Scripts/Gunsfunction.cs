using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gunsfunction : MonoBehaviour
{
    public ParticleSystem Shoteffects;
    public AudioSource Gunsounds;
    public Camera Aimcamera;
    public float Range;
    public Text[] Scores;
    public Text AmmoUI;
    public int Ammo = 30;
    public int Maxammo;
    public Animator Ammocase;
    bool Reloadin = false;
    public Scorescript Truescore;
    public Playershealth Mainhealth;
    public bool Flamethrowershoot = false;
    public bool noanimations;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Flamethrowershoot == true)
        {
            //Flame effects
            RaycastHit Burned;
            if(Physics.Raycast(Aimcamera.transform.position,Aimcamera.transform.forward,out Burned, 50f))
            {
                if(Burned.transform.gameObject.tag == "Enemies")
                {
                    Burned.transform.gameObject.SetActive(false);
                    Truescore.Scores += 1;  
                }
                if (Burned.transform.gameObject.tag == "Wastelandersballs")
                {
                    Burned.transform.gameObject.SetActive(false);
                    Truescore.Scores += 1;
                }
            }
        }
        //Display the numbers of enemies you've killed
        Scores[0].text = Truescore.Scores.ToString();
        //Display the ammo count
        AmmoUI.text = Ammo.ToString();
        //If there's less than one ammo then reload
        if (Ammo <= 1)
        {
            StartCoroutine(Reloading());
        }
        //Detect for other collectible/goods 
        RaycastHit Finditems;
        if(Physics.Raycast(Aimcamera.transform.position,Aimcamera.transform.forward,out Finditems, 20f))
        {
            if(Finditems.transform.gameObject.tag == "Medkit")
            {
                Scores[1].gameObject.SetActive(true);
            }
            if(Finditems.transform.gameObject.tag == "floors")
            {
                Scores[1].gameObject.SetActive(false);
            }
        }
    }

    public void Shoottheguns()
    {
        //When the shoot button is pressed it plays the gun shot sound 
        //and effects and shoot at the same time
        //If the reloading is false of course
        if (Reloadin == false)
        {
            Shoteffects.Play();
            Gunsounds.Play();
            Ammo -= 1;
            RaycastHit Rayhit;
            if (Physics.Raycast(Aimcamera.transform.position, Aimcamera.transform.forward, out Rayhit, Range))
            {
                Debug.Log(Rayhit.transform);
                //kills the robot and increases the score
                if (Rayhit.transform.gameObject.tag == "Enemies")
                {
                    Rayhit.transform.gameObject.SetActive(false);
                    Truescore.Scores += 1;
                }
                if (Rayhit.transform.gameObject.tag == "Wastelandersballs")
                {
                    Rayhit.transform.gameObject.SetActive(false);
                    Truescore.Scores += 1;
                }
                //If collected the medkit then make the medkit disapear and add health;
                if (Rayhit.transform.gameObject.tag == "Medkit")
                {
                    Scores[1].gameObject.SetActive(false);
                    Rayhit.transform.gameObject.SetActive(false);
                    Mainhealth.health += 45;  
                }
            }
        }
    }

        IEnumerator Reloading()
        {
            //Set Reload bool true and play the reloading animation
            Reloadin = true;
        if(noanimations == false)
        {
            Ammocase.SetBool("Reload", true);
        }
            yield return new WaitForSeconds(3f);
            //After that it stops playing the reloading animations
            Ammo = Maxammo;
        if (noanimations == false)
        {
            Ammocase.SetBool("Reload", false);
        }
            yield return new WaitForSeconds(1f);
            Reloadin = false;   
        }

        public void Reloadammo()
        {
            StartCoroutine(Reloading());
        }

    public void Flamethrower()
    {
        //Enable the end weapon script
        transform.GetComponent<Endweapon>().enabled = true;
        //Start the proccess of using the whole of Flamethrower
        StartCoroutine(flammenwerfer());
    }

    public void OnEnable()
    {
         if(Reloadin == false)
        {
            Ammocase.SetBool("Reload", false);
        }
    }

    IEnumerator flammenwerfer()
    {
        Ammocase.enabled = true;
        yield return new WaitForSeconds(2f);
        Ammocase.enabled = false;
        Shoteffects.Play();
        Flamethrowershoot = true;
        Gunsounds.Play();
        yield return new WaitForSeconds(6f);
        Flamethrowershoot = false;
        transform.GetComponent<Endweapon>().Switchtime = true;
    }

    public void turnoffscript()
    {       
        //Turn off the script to turn on the flamethrower again
        transform.GetComponent<Endweapon>().enabled = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorescript : MonoBehaviour
{
    public int Scores;
    [HideInInspector]
    public bool Correctscoretext;
    public float restartimers = 30f;
    public GameObject[]Flammenwerffer;
    public Text Changetxt;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if(Correctscoretext == true)
        {
            int Actualscore = PlayerPrefs.GetInt("Scores");
            transform.GetComponent<Text>().text = Actualscore.ToString();
        }
        //If Endweapon script has switchtime is true
        if(Flammenwerffer[1].GetComponent<Endweapon>().Switchtime == true)
        {
            Flammenwerffer[2].GetComponent<GunslevelUnlock>().Flamethroweroff = false;
            if (restartimers >= 0f)
            {
                //start the timer and set these things to true;
                restartimers -= 1f * Time.deltaTime;
                Flammenwerffer[0].gameObject.SetActive(true);
                Changetxt.text = "You have" + restartimers + "left till you can use the weapon";
            }
        }
        if(restartimers <= 0f)
        {
            Flammenwerffer[2].GetComponent<GunslevelUnlock>().Flamethroweroff = true ;
            Flammenwerffer[0].gameObject.SetActive(false);
        }
    }

    public void Savescores()
    {
        PlayerPrefs.SetInt("Scores", Scores);
        PlayerPrefs.Save();
    }

    public void Restartimers()
    {
        restartimers = 30f;
    }
}

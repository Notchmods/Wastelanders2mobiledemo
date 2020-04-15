using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIskritpt : MonoBehaviour
{
    public bool Loadingscreen = false;
    public bool Startingpart = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Loadingscreen == true)
        {
            SceneManager.LoadScene(1);
        }
        if(Startingpart == true)
        {
            Time.timeScale = 0;
        } 
    }

    public void Startthegame()
    {
        SceneManager.LoadScene(3); 
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Setittonormalspeed()
    {
        Time.timeScale = 1;
    }
}

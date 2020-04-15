using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyscript : MonoBehaviour
{
    //Disable the object after 2 seconds
    public float time;

    private void OnEnable()
    {
        Invoke("Destroy", time);
    }

    public void Destroy()
    {
        gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creepingbarrage : MonoBehaviour
{
    public GameObject[] Artilleries_row;
    public GameObject Mainplayers;
    bool Endartillery;
    // Start when it's enabled
    void OnEnable()
    {
        StartCoroutine(Creeping_barrage());
    }
        
    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < Artilleries_row.Length; i++)
        {
            if (Vector3.Distance(Artilleries_row[i].transform.position, Mainplayers.transform.position)<30f){
                Mainplayers.transform.GetComponent<Playershealth>().health -= 5f;
            }
        }
        if(Artilleries_row[14].activeInHierarchy == false)
        {
            if(Endartillery == true){
                this.enabled = false;
                Endartillery = false;
                Debug.Log(Endartillery);
            }
        }
    }

    IEnumerator Creeping_barrage()
    {
        Artilleries_row[0].gameObject.SetActive(true);
        Artilleries_row[1].gameObject.SetActive(true);
        Artilleries_row[2].gameObject.SetActive(true);
        Artilleries_row[3].gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        Artilleries_row[4].gameObject.SetActive(true);
        Artilleries_row[5].gameObject.SetActive(true);
        Artilleries_row[6].gameObject.SetActive(true);
        Artilleries_row[7].gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        Artilleries_row[8].gameObject.SetActive(true);
        Artilleries_row[9].gameObject.SetActive(true);
        Artilleries_row[10].gameObject.SetActive(true);
        Artilleries_row[11].gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        Artilleries_row[12].gameObject.SetActive(true);
        Artilleries_row[13].gameObject.SetActive(true);
        Artilleries_row[14].gameObject.SetActive(true);
        Artilleries_row[15].gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        Endartillery = true;
    }
    public void Start_Artilleries() 
    {
        Endartillery = false;
    }
}

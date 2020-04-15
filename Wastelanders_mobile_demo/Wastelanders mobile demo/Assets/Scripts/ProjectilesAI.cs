using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilesAI : MonoBehaviour
{
    public GameObject Pooledobject;
    public int pooledammountes = 10;
    [SerializeField]
    public List<GameObject> pooledobjectes;
    public List<GameObject> Ammoeinstantiates;
    Rigidbody Ammunitions;
    public GameObject Mainplayer;
    // Start is called before the first frame update
    void Start()
    {
        //Declare pooledobject variable as a list
        pooledobjectes = new List<GameObject>();
        for (int i = 0; i < 10; i++)
        {
            //Pre instantiate the object in the list
            GameObject objektes = (GameObject)Instantiate(Pooledobject);
            objektes.SetActive(false);
            //Add gameobject to Objektes list
            pooledobjectes.Add(objektes);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Mainplayer.transform.position);
        if (Vector3.Distance(transform.position, Mainplayer.transform.position) < 38)
        {
            Firetheguns();
        }
    }

    public void Firetheguns()
    {
        for (int i = 0; i < pooledammountes; i++)
        {
            //If pooledobject is not set active in Hierarchy return the value of the list
            if (!pooledobjectes[i].activeInHierarchy)
            {
                pooledobjectes[i].transform.LookAt(Mainplayer.transform.position);
                pooledobjectes[i].transform.position = transform.position;
                pooledobjectes[i].transform.rotation = transform.rotation;
                pooledobjectes[i].SetActive(true);
                Ammunitions = pooledobjectes[i].GetComponent<Rigidbody>();
                Ammunitions.AddForce(Vector3.forward * 10000*Time.deltaTime);
                break;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    bool object_spawned;
    private Placementndicator placementndicator;
    private GameObject obj;
    public GameObject visual;


    // Start is called before the first frame update
    void Start()
    {

        object_spawned = false;
        placementndicator = FindObjectOfType<Placementndicator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount >0 && Input.touches[0].phase == TouchPhase.Began)
        {
            if(!object_spawned)
            {
                obj = Instantiate(objectToSpawn, placementndicator.transform.position, placementndicator.transform.rotation);
                object_spawned = true;
                visual.SetActive(false);
            }
            else
            {
                obj.transform.position = placementndicator.transform.position;
                
            }
            //GameObject obj = Instantiate(objectToSpawn, placementndicator.transform.position, placementndicator.transform.rotation);
            
        }
    }
}

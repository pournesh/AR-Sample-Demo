using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Gaze : MonoBehaviour
{
    List<InfoBehaviour> infos = new List<InfoBehaviour>();
    Vector3 desiredScale = Vector3.zero;

    // Start is called before the first frame update
    void Awake()
    {
        infos = FindObjectsOfType<InfoBehaviour>().ToList();
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position,transform.forward,out RaycastHit hit))
        {
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("hasInfo"))
            {
                print("Here");
                OpenInfo(go.GetComponent<InfoBehaviour>());
            }
        }
        else
        {
            CloseAll();
        }
    }

    void OpenInfo(InfoBehaviour desiredInfo)
    {
        foreach(InfoBehaviour info in infos)
        {
            if(info == desiredInfo)
            {
                //info.OpenInfo();
                OpenInfo();
            }
            else
            {
                //info.CloseInfo();
                CloseInfo();
            }
        }
    }

    void CloseAll()
    {
        foreach (InfoBehaviour info in infos)
        {
            //info.CloseInfo();
            CloseInfo();
        }
    }

    public void OpenInfo()
    {
        desiredScale = Vector3.one;
    }

    public void CloseInfo()
    {
        desiredScale = Vector3.zero;
    }
}

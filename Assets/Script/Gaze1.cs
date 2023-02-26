using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Gaze1 : MonoBehaviour
{
    //List<InfoBehaviour> infos = new List<InfoBehaviour>();
    Vector3 desiredScale = Vector3.zero;
    GameObject obtofind;
    Transform sectionInfo;
    float speed = 6;
    bool isplaced = false;
    private InfoBehaviour infos;

    // Start is called before the first frame update
    void Awake()
    {
        //infos = get<InfoBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {

            GameObject go = hit.collider.gameObject;
            if (go.tag == "hasInfo")
            {
                infos = go.GetComponent<InfoBehaviour>();
                infos.OpenInfo();


                print("Here pointing");
                isplaced = true;

                //OpenInfo(go.GetComponent<InfoBehaviour>());
              /*  if (go.transform.childCount >= 1 && go.transform.GetChild(0).name == "SectionInfo")
                {

                    obtofind = go.transform.GetChild(0).gameObject;

                }
                sectionInfo = obtofind.transform;
                Debug.Log(sectionInfo.position.x);
                //desiredScale = new Vector3(2,2,2);
                //obtofind.transform.localScale = Vector3.Lerp(sectionInfo.localScale, desiredScale, Time.deltaTime * speed);
                //obtofind.transform.localScale = new Vector3(2, 2, 2);
              */
            }
            else if (isplaced == true)
            {
                print("Not Pointing");
                //desiredScale = new Vector3(0,0,0);
                infos.CloseInfo();
                //obtofind.transform.localScale = Vector3.Lerp(sectionInfo.localScale, desiredScale, Time.deltaTime * speed);
                //obtofind.transform.localScale = new Vector3(0, 0, 0);
            }
        }
        else if (isplaced == true)
        {
            print("Not Pointing");
            //desiredScale = new Vector3(0,0,0);
            infos.CloseInfo();
            //obtofind.transform.localScale = Vector3.Lerp(sectionInfo.localScale, desiredScale, Time.deltaTime * speed);
            //obtofind.transform.localScale = new Vector3(0, 0, 0);
        }



        }

        /*  void OpenInfo(InfoBehaviour desiredInfo)
          {
              foreach (InfoBehaviour info in infos)
              {
                  if (info == desiredInfo)
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
        */
        public void OpenInfo()
    {
        desiredScale = Vector3.one;
    }

    public void CloseInfo()
    {
        desiredScale = Vector3.zero;
    } 
}

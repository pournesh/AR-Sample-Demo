using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class API : MonoBehaviour
{
    const string ENDPOINT = "https://datausa.io/api/data?drilldowns=Nation&measures=Population";

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        GetTimeData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Obsolete]
    public void GetTimeData()
    {
        StartCoroutine(GetTimedataRoutine());
    }

    [System.Obsolete]
    IEnumerator GetTimedataRoutine()
    {
        UnityWebRequest request = UnityWebRequest.Get(ENDPOINT);
        yield return request.SendWebRequest();

        if (request.isNetworkError)
        {
            Debug.Log("Network Error");
        }
        else
        {
            ParseData(request.downloadHandler.text);
        }
    }

    void ParseData(string data)
    {
        Debug.Log(data);
    }
}

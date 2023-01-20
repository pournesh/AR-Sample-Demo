using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Splash_Controller : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LoadApp());
    }

    // Update is called once per frame
    IEnumerator LoadApp()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
    }
}

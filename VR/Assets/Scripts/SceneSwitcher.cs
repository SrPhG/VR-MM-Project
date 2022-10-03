using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey("")) 
        {
            Debug.Log("hello");
            //SceneManager.LoadScene(1);
        }
    }

}

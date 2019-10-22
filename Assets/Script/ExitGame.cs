using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ExitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Exit()
    {
        Debug.Log("hi");
        if (EditorApplication.isPlaying)
        {
            EditorApplication.isPlaying = false;
        }
        else
        {
            //if users are using the build option
            Application.Quit();
        }

    }
}

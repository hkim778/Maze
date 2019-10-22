using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMain : MonoBehaviour
{
    private GameObject leaders;
    private GameObject passOn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ExitMain()
    {
        SceneManager.LoadScene("TitleScreen");
    }

}

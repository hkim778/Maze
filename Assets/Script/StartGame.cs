using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private GameObject leaders;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GameStart()
    {

        if(GameObject.Find("ListOfLeaders") != null)
        {
            leaders = GameObject.Find("ListOfLeaders");
            DontDestroyOnLoad(leaders);
        }

        SceneManager.LoadScene("Maze");
    }



}

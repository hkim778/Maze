using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeavingLastRoom : MonoBehaviour
{
    //private GameObject[] gameObjects;

    public bool ending;

    // Start is called before the first frame update
    private void Start()
    {
        ending = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            ending = true;
            SceneManager.LoadScene("LeaderBoard");
        }

    }
}

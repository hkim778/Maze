using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timer;
    [HideInInspector]
    public float seconds = 0f;
    [HideInInspector]
    public float minutes = 0f;


    private NameSubmit nameCheck;

    private Pause pauseGame;
   

    private void Start()
    {  
        nameCheck = GameObject.Find("Submit").GetComponent<NameSubmit>();
        pauseGame = GameObject.Find("GameControl").GetComponent<Pause>();
    }

    void Update() {
        if(nameCheck.check)
        {
            if (pauseGame.stop == false)
            {
                seconds += Time.deltaTime;
            }
        }
        if (seconds >= 60)
        {
            minutes++;
            seconds = 0;
        }

        //update the label value
        timer.text = string.Format ("{0:00} : {1:00}", minutes, seconds);
    }


}
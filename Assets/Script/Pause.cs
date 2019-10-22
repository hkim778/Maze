using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject panel;
    public bool stop;

    private NameSubmit submitName;

    private void Start()
    {
        stop = false;
        submitName = GameObject.Find("Submit").GetComponent<NameSubmit>();
    }
    // Update is called once per frame
    void Update()
    {
        if(submitName.check)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Debug.Log("pause");
                if (panel.activeSelf == true)
                {
                    panel.SetActive(false);
                    stop = false;
                }
                else
                {
                    panel.SetActive(true);
                    stop = true;

                }
            }
        }

    }
}

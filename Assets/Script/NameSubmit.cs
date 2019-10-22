using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NameSubmit : MonoBehaviour
{
    [HideInInspector]
    public bool check;

    private InputField input;

    [HideInInspector]
    public string userName;
    // Start is called before the first frame update
    void Start()
    {
        input = GameObject.Find("NameInput").GetComponent<InputField>();


        check = false;
    }

    public void SubmitName()
    {
        var panel = GameObject.Find("NameSubmit");

        panel.SetActive(false);
        check = true;

        if (input.text.Length > 3)
        {
            for (var i = 0; i <3;i ++)
            {
                userName += input.text[i];
            }
        }
        else
        {
            userName = input.text;

        }
    }
}

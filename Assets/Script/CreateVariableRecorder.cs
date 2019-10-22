using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateVariableRecorder : MonoBehaviour
{
    GameObject variableHolder;
    string recordName;
    // Start is called before the first frame update
    void Start()
    {

        //finds all the previous scorekeeping objects created
        if (GameObject.FindGameObjectsWithTag("scoreKeeping") != null)
        {
            GameObject[] holder = GameObject.FindGameObjectsWithTag("scoreKeeping");
            recordName = "Record " + holder.Length.ToString("00");

            variableHolder = new GameObject(recordName);
            variableHolder.gameObject.tag = "scoreKeeping";
            variableHolder.AddComponent<LoadVariables>();
        }
    }
}

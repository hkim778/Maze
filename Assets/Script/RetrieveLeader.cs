using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetrieveLeader : MonoBehaviour
{

    public string userName;
    public float minutes;
    public float seconds;
    

    public RetrieveLeader(string name, float minute, float second)
    {
        userName = name;
        minutes = minute;
        seconds = second;
    }
    [HideInInspector]
    public LoadVariables load;


    public List<RetrieveLeader> timeOrder = new List<RetrieveLeader>();
    public bool oneTime = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (var i = 0; i<timeOrder.Count;i++)
        {
            Debug.Log(timeOrder[i].userName);
        }
    }
}

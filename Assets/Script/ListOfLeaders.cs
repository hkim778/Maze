using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOfLeaders : MonoBehaviour
{

    public List<GameObject> lists = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (var i=0; i<lists.Count;i++)
        {
            Debug.Log(lists[i].GetComponent<LoadVariables>().userName);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeaderBoardControl : MonoBehaviour
{
    public GameObject[] mazeObjects;


    private NameSubmit nameCheck;
    private Timer time;
    private LeavingLastRoom lastRoom;

    [HideInInspector]
    public LoadVariables load;


    private bool check;
    private Text rank1;
    private Text rank2;
    private Text rank3;
    private Text rank4;
    private Text rank5;





    // Start is called before the first frame update
    void Start()
    {

        check = false;
        if(GameObject.FindGameObjectsWithTag("leaderBoard").Length==1)
        {
            DontDestroyOnLoad(this.gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("GameControl") != null)
        {
            time = GameObject.Find("GameControl").GetComponent<Timer>();
        }

        if (GameObject.Find("Submit")!=null)
        {
            nameCheck = GameObject.Find("Submit").GetComponent<NameSubmit>();
        }

        if (GameObject.Find("DetectionRoomThree") != null)
        {
            lastRoom = GameObject.Find("DetectionRoomThree").GetComponent<LeavingLastRoom>();
        }


        //if the leader goes into the maze scene from the start screen, it will access all the game object
        if (SceneManager.GetSceneByName("Maze").IsValid())
        {
            check = false;

            mazeObjects = GameObject.FindGameObjectsWithTag("scoreKeeping");
            for (var i = 0; i < mazeObjects.Length; i++)
            {
                if(mazeObjects[i].scene.name == "Maze")
                {
                    //before we add the object as the child, we have to retrieve the value
                    load = mazeObjects[i].GetComponent<LoadVariables>();
                    if(lastRoom.ending)
                    {
                        load.userName = nameCheck.userName;
                        load.minutes = time.minutes;
                        load.seconds = time.seconds;
                        //if the scorekeeping exists in the hierarchy, it will become a child of the list
                        mazeObjects[i].transform.SetParent(this.gameObject.transform);
                    }
                }
            }
            

        }
        if (SceneManager.GetSceneByName("LeaderBoard").IsValid())
        {

            rank1 = GameObject.Find("NumberOne").GetComponent<Text>();
            rank2 = GameObject.Find("NumberTwo").GetComponent<Text>();
            rank3 = GameObject.Find("NumberThree").GetComponent<Text>();
            rank4 = GameObject.Find("NumberFour").GetComponent<Text>();
            rank5 = GameObject.Find("NumberFive").GetComponent<Text>();

            if (check == false)
            {
                for (var i = 0; i < mazeObjects.Length; i++)
                {

                    //Debug.Log(mazeObjects[i].GetComponent<LoadVariables>().userName);
                    string threeLetterName = mazeObjects[i].GetComponent<LoadVariables>().userName;
                    float minute = mazeObjects[i].GetComponent<LoadVariables>().minutes;
                    float second = mazeObjects[i].GetComponent<LoadVariables>().seconds;

                    //sorting minutes
                    for (var j = (i+1); j<mazeObjects.Length; j++)
                    {
                        float compareMinute = mazeObjects[j].GetComponent<LoadVariables>().minutes;
                        float compareSecond = mazeObjects[j].GetComponent<LoadVariables>().seconds;

                        //minutes comparation
                        if (minute > compareMinute)
                        {
                            GameObject temp = mazeObjects[i];
                            mazeObjects[i] = mazeObjects[j];
                            mazeObjects[j] = temp;
                            
                        }

                        else if ((int)minute == (int)compareMinute)
                        {
                            //if the seconds are the same
                            if (second > compareSecond)
                            {
                                GameObject temp = mazeObjects[i];
                                mazeObjects[i] = mazeObjects[j];
                                mazeObjects[j] = temp;

                            }
                        }

                    }




                }


                if (mazeObjects.Length>=1)
                {
                    rank1.text =TextUpdate(0);

                }
                if (mazeObjects.Length >= 2)
                {
                    rank2.text =TextUpdate(1);

                }
                if (mazeObjects.Length >= 3)
                {
                    rank3.text =TextUpdate(2);

                }
                if (mazeObjects.Length >= 4)
                {
                    rank4.text =TextUpdate(3);

                }
                if (mazeObjects.Length >= 5)
                {
                    rank5.text =TextUpdate(4);

                }



                check = true;
            }

        }


    }
    private string TextUpdate(int length)
    {
        string uName = mazeObjects[length].GetComponent<LoadVariables>().userName;
        string minute = mazeObjects[length].GetComponent<LoadVariables>().minutes.ToString("00");
        string second = mazeObjects[length].GetComponent<LoadVariables>().seconds.ToString("00");

        int number = length + 1;
        return (number + ". " + uName + " " + minute + " : " + second);
    }
}



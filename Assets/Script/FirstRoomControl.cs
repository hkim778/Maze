using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstRoomControl : MonoBehaviour
{
    public GameObject player;
    public GameObject first;
    public GameObject second;
    public GameObject third;

    public GameObject door;
    public GameObject key;

    private bool f;
    private bool s;
    private bool t;
    private bool k;

    private bool test;
    private Vector3 playerLoc;

    

    private List<GameObject> roomOne;
    //private List<string> check;
    private List<string> check;
    private List<string> order = new List<string> { "first", "second", "third" };
    private List<GameObject> location = new List<GameObject>();
    private List<bool> trueOrFalse = new List<bool> { true, true, true };

    // Start is called before the first frame update
    private void Start()
    {
        check = new List<string>();

        roomOne = new List<GameObject>
        {
            first,
            second,
            third
        };




        playerLoc = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);


        f = false;
        s = false;
        t = false;

        test = true;
        k = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (k == true)
        {


            for (var i = 0; i < roomOne.Count; i++)
            {
                if (roomOne[i].activeSelf == false)
                    {
                    if (roomOne[i] == first && f == false)
                    {

                        check.Add("first");

                        f = true;
                    }
                    else if (roomOne[i] == second && s == false)
                    {

                        check.Add("second");
                        s = true;
                    }
                    else if (roomOne[i] == third && t == false)
                    {

                        check.Add("third");
                        t = true;
                    }
                }
            }
            if (f == true && t == true && s == true)
            {
                CheckOrder();
                // if the pattern did not match with the answer
                if (test == false)
                {
                    Respawn();
                    VariableConstruct();
                }
                //spawn key
                else
                {
                    KeySpawn();
                }
            }
        }
    }
    private void CheckOrder()
    {

        for ( var i = 0; i < check.Count; i += 1)
        {
            //checks if order is right
            if (check[i] == order[i])
            {
                //it's true
            
            }
            else
            {
                //not all of it was true
                test = false;
                Debug.Log("wrong order");
                return;
            }
        }
    }

    //respawn when the order is wrong
    private void Respawn()
    {
        //try to move the player so it respawns
        player.transform.position = playerLoc;
       
        for (var i = 0; i < roomOne.Count; i++)
        {
            roomOne[i].SetActive(true);

        }
        check.Clear();



    }

    private void KeySpawn()
    {
        if (key != null) 
        {
            key.SetActive(true);
        }
        else
        {
            door.transform.Rotate(0, 180, 0);
            k = false;
        }

    }

    private void VariableConstruct()
    {
        //construct variable
        f = false;
        s = false;
        t = false;

        test = true;
    }


}

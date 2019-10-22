using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightController : MonoBehaviour
{

    float speed = 4;
    float rotSpeed = 80;
    float rotation = 0f;
    float gravity = 8;

    Vector3 moveDir = Vector3.zero;

    CharacterController charControl;
    Animator ani;

    private GameObject submit;
    private NameSubmit nameCheck;
    // Start is called before the first frame update
    void Start()
    {
        charControl = GetComponent<CharacterController>();
        ani = GetComponent<Animator>();

        submit = GameObject.Find("Submit");
        nameCheck = submit.GetComponent<NameSubmit>();
    }

    // Update is called once per frame
    void Update()
    {
        if(nameCheck.check)
        {
            if (charControl.isGrounded)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    ani.SetInteger("condition", 1);
                    moveDir = new Vector3(0, 0, 1);
                    moveDir *= speed;

                    //move forward depending on the rotation of the player
                    moveDir = transform.TransformDirection(moveDir);


                }
                if (Input.GetKeyUp(KeyCode.W))
                {
                    ani.SetInteger("condition", 0);
                    moveDir = new Vector3(0, 0, 0);
                }
                //rotation of the player
                rotation += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
                transform.eulerAngles = new Vector3(0, rotation, 0);

                moveDir.y -= gravity * Time.deltaTime;
                charControl.Move(moveDir * Time.deltaTime);
            }
        }

       



    }
}

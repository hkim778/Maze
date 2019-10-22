using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeavingSecondRoom : MonoBehaviour
{
    public GameObject secondInstruction;
    public GameObject thirdInstruction;

    public GameObject red;
    public GameObject blue;
    public GameObject green;
    public GameObject key;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Destroy(secondInstruction);
            Camera mainCamera = Camera.main;
            CameraControl cctrl = mainCamera.GetComponent<CameraControl>();

            cctrl.offset = new Vector3(0, 3f, -5f);
            thirdInstruction.SetActive(true);

            red.SetActive(true);
            green.SetActive(true);
            blue.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}

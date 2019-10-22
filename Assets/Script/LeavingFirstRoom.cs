using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeavingFirstRoom : MonoBehaviour
{
    public GameObject firstInstruction;
    public GameObject secondInstruction;

    public GameObject red;
    public GameObject blue;
    public GameObject green;

    public GameObject key;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Destroy(firstInstruction);
            Camera mainCamera = Camera.main;
            CameraControl cctrl = mainCamera.GetComponent<CameraControl>();

            cctrl.offset = new Vector3(0, 3f, -5f);
            secondInstruction.SetActive(true);

            red.SetActive(true);
            green.SetActive(true);
            blue.SetActive(true);
            key.SetActive(false);

            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollisions : MonoBehaviour
{
    public GameObject door;
    public GameObject door2;
    public GameObject door3;
    public GameObject door4;
    public GameObject door5;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            door.SetActive(false);
        if (Input.GetKeyDown(KeyCode.V))
            door2.SetActive(false);
        if (Input.GetKeyDown(KeyCode.J))
            door3.SetActive(false);
        if (Input.GetKeyDown(KeyCode.C))
            door4.SetActive(false);
        if (Input.GetKeyDown(KeyCode.T))
            door5.SetActive(false);
    }
}

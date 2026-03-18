using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUnlock : MonoBehaviour
{
    public GameObject door;
    public DisguiseKit kit;

    public bool canOpenDoor = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DoorOpen();
    }

    public void DoorOpen()
    {
        if (canOpenDoor && Input.GetKeyDown(KeyCode.R) && kit.isElectric)
        {
            door.SetActive(false);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            canOpenDoor = true;
        }
        else
        {
            canOpenDoor = false;
        }
    }
}

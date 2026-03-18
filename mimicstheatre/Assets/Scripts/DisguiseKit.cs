using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisguiseKit : MonoBehaviour
{
    public GameObject disguise;

    public bool canPickKit;
    public bool hasKit = false;

    public bool isElectric = false;
    public bool isActor = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KitPickup();
        KitGarbage();
    }

    public void KitPickup()
    {
        if (canPickKit && Input.GetKeyDown(KeyCode.R))
        {
            disguise.SetActive(false);
            hasKit = true;
        }
    }

    public void KitGarbage()
    {
        if (hasKit && Input.GetKeyDown(KeyCode.Alpha1))
        {
            isElectric = true;
            isActor = false;
        }
        if (hasKit && Input.GetKeyDown(KeyCode.Alpha2))
        {
            isElectric = false;
            isActor = true;
        }

        //reduce range for vision if either are picked
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Disguise")
        {
            canPickKit = true;
        }
        else
        {
            canPickKit = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    public bool hasBucket = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Bucket" && Input.GetKeyDown(KeyCode.R))
        {
            other.gameObject.SetActive(false);
            hasBucket = true;
        }
    }
}

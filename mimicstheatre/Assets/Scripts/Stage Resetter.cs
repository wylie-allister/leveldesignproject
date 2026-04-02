using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageResetter : MonoBehaviour
{
    public GameObject respawnPoint;
    //public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = respawnPoint.transform.position;
        }
    }
}

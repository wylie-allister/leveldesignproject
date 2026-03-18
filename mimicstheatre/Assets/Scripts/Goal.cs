using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int lightTracker = 0;
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
        if (other.tag == "LeftLight")
        {
            Debug.Log("ping");
            lightTracker++;
        }

        if (other.tag == "RightLight")
        {
            Debug.Log("pong");
            lightTracker++;
        }
    }
}

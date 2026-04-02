using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour
{
    MeshRenderer mr;

    bool glowShow = false;
    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (glowShow)
        {
            mr.enabled = true;
        }
        else
        {
            mr.enabled = false;
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            glowShow = true;
        }
        else
        {
            glowShow = false;
        }
    }
}

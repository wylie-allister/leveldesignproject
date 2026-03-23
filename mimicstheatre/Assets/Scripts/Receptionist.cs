using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receptionist : MonoBehaviour
{
    public float curRot;

    public bool rotLeft = true;
    public bool rotRight = false;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curRot = transform.rotation.y;

        if (rotLeft)
        {
            if (curRot >= 0.8f)
            {
                rotLeft = false;
                rotRight = true;
            }
            RotateLeft();
        }
        else if (rotRight)
        {
            if (curRot <= -0.8f)
            {
                rotRight = false;
                rotLeft = true;
            }
            RotateRight();
        }

    }

    public void RotateLeft()
    {
        float lrotation = 10 * Time.deltaTime;
        transform.Rotate(0, lrotation, 0);
    }

    public void RotateRight()
    {
        float rrotation = -10 * Time.deltaTime;
        transform.Rotate(0, rrotation, 0);
    }

    
}

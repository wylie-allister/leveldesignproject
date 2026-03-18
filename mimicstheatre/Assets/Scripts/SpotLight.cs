using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLight : MonoBehaviour
{
    public float xInput;
    public float yInput;
    public float moveSpeed = 1.2f;

    public bool isLeftActive = true;

    [SerializeField]
    private LightSide _lightSide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isLeftActive = !isLeftActive;
        }

        if (this.tag == "LeftLight" && isLeftActive)
        {
            this.Movement();
        }
        else if (this.tag == "RightLight" && !isLeftActive)
        {
            this.Movement();
        }


    }

    public void Movement()
    {
        xInput = Input.GetAxis("Horizontal") * moveSpeed;
        yInput = Input.GetAxis("Vertical") * moveSpeed;

        transform.Rotate(yInput, xInput, 0);
    }
}

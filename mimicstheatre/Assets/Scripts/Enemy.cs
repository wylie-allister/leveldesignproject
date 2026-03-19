using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public LayerMask player;
    public LayerMask ob;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (!Physics.Raycast(transform.position, fwd, 2, ob))
            {
            if (Physics.Raycast(transform.position, fwd, 5, player))
            {
                Debug.Log("AAAAAAAAAA");
                UhOh();
            }
        }
    }

    public void UhOh()
    {
        //replace with waypoints oh my god do not leave this code like this
        SceneManager.LoadScene("Theatre");
    }

    public void Rotation()
    {
        float rotation = 20 * Time.deltaTime;
         transform.Rotate(0, rotation, 0); 
    }
}

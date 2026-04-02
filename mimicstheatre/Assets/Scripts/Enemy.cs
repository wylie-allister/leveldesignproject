using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public LayerMask player;
    public LayerMask ob;

    public GameObject pl;
    public Respawn rs;
    public Bucket bk;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (!Physics.Raycast(transform.position, fwd, 5, ob))
            {
            if (Physics.Raycast(transform.position, fwd, 5, player))
            {
                //Debug.Log("AAAAAAAAAA");
                UhOh();
            }
        }
        
    }

    public void UhOh()
    {
            Debug.Log("AAAAAAAAAA");
            pl.transform.position = rs.respawnPoints[bk.respawnArea].transform.position;
        
    }

    public void Rotation()
    {
        float rotation = 20 * Time.deltaTime;
         transform.Rotate(0, rotation, 0); 
    }
}

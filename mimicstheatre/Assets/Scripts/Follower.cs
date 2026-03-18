using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public GameObject lightPoint;
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 0, 0);  
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lpTrack = new Vector3(lightPoint.transform.position.x, 0.5f, lightPoint.transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, lpTrack, speed * Time.deltaTime);
    }
}

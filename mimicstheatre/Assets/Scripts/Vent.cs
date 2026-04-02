using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vent : MonoBehaviour
{
    public GameObject vent;

    public bool canOpen = false;
    public bool timerStart = false;
    public float timerLength = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canOpen && Input.GetKeyDown(KeyCode.R))
        {
            timerStart = true;

        }

        if (timerStart)
        {
            timerLength -= Time.deltaTime;
        }

        if (timerLength <= 0)
        {
            
            vent.SetActive(false);
            timerStart = false;
        }

    }

    public void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Vent")
        {
            canOpen = true;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Spotted" && timerStart)
        {
            SceneManager.LoadScene("Theatre");
        }
    }
}

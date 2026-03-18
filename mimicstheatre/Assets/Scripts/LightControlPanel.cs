using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControlPanel : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject stageCam;
    public GameObject player;
    bool camSwap = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CamSwap()
    {

        if (camSwap)
        {
            mainCam.SetActive(false);
            player.SetActive(false);
            stageCam.SetActive(true);
        }
        else if (!camSwap)
        {
            mainCam.SetActive(true);
            player.SetActive(true);
            stageCam.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("ping");
            if (Input.GetKeyDown(KeyCode.R))
            {
                camSwap = !camSwap;
                CamSwap();
            }
        }
    }
}

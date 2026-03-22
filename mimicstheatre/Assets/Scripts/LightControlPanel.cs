using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LightControlPanel : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject stageCam;
    public GameObject player;
    public bool camSwap = false;
    public bool canUseCamera = false;
    public bool canMove = true;
    public bool moveLight = false;

    public GameObject lightGuide;
    public GameObject controlGuide;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canUseCamera && camSwap && Input.GetKeyDown(KeyCode.R))
        {
            CamSwap();
            camSwap = false;
            canMove = false;

        }
        else if (canUseCamera && !camSwap && Input.GetKeyDown(KeyCode.R))
        {
            CamSwap();
            camSwap = true;
            canMove = true;
        }
    }

    public void CamSwap()
    {

        if (camSwap)
        {
            
            mainCam.SetActive(false);
            //player.SetActive(false);
            stageCam.SetActive(true);
            moveLight = true;
            lightGuide.SetActive(true);
            controlGuide.SetActive(false);
        }
        else if (!camSwap)
        {
            mainCam.SetActive(true);
            //player.SetActive(true);
            stageCam.SetActive(false);
            moveLight = false;
            lightGuide.SetActive(false);
            controlGuide.SetActive(true);
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canUseCamera = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            canUseCamera = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControlPanel : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject stageCam;
    public GameObject player;
    public bool camSwap = false;
    public bool canUseCamera = false;
    public bool canMove = true;
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
        }
        else if (!camSwap)
        {
            mainCam.SetActive(true);
            //player.SetActive(true);
            stageCam.SetActive(false);
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canUseCamera = true;
        }
    }
}

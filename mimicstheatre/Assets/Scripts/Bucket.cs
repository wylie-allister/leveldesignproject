using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bucket : MonoBehaviour
{
    public bool hasBucket = false;

    public GameObject guy;
    public GameObject monster;
    public GameObject bucket;

    bool canBucket = false;
    bool canMonster = false;
    bool canRafters = false;

    public Goal goal;

    public TextMeshProUGUI currentDisguise;
    public TextMeshProUGUI inventoryUpdate;
    public GameObject electricAnnounc;

    public int respawnArea = 0;
    public bool timerStart;
    public float timerLength = 10;
    public bool timerPrereq;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        InputShit();
    }

    public void InputShit()
    {
        if (canBucket && Input.GetKeyDown(KeyCode.R))
        {
            bucket.SetActive(false);
            hasBucket = true;
            inventoryUpdate.text = "Inventory: Bucket";
            respawnArea = 1;
        }

        if (canMonster && Input.GetKeyDown(KeyCode.R))
        {
            guy.SetActive(false);
            monster.SetActive(true);
            electricAnnounc.SetActive(true);
            timerStart = true;
            respawnArea = 2;
           
        }

        if (canRafters && Input.GetKeyDown(KeyCode.R) && goal.lightTracker >= 2)
        {
            Debug.Log("You did it! Good Jorb!");
            SceneManager.LoadScene("EndScreen");
            //cutscene
        }

        if (timerStart)
        {
            timerLength -= Time.deltaTime;
        }

        if (timerLength <= 0)
        {

            electricAnnounc.SetActive(false);
            timerStart = false;
        }
    }

    public void TextTimer()
    {
            timerStart = true;

        if (timerStart)
        {
            timerLength -= Time.deltaTime;
        }

        if (timerLength <= 0)
        {

            electricAnnounc.SetActive(false);
            timerStart = false;
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Bucket")
        {
            canBucket = true;
        }
        else
        {
            canBucket = false;
        }

        if (other.tag == "Changing" && hasBucket)
        {
            canMonster = true;
        }
        else
        {
            canMonster = false;
        }

        if (other.tag == "Rafter" && hasBucket)
        {
            //Play end cutscene, whatever that means (maybe i'll hand draw something idk)
            canRafters = true;
        }
        else
        {
            canRafters = false;
        }
    }
}

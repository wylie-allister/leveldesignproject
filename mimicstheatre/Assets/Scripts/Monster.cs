using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Monster : MonoBehaviour
{

    public int pitch = 1;
    public AudioSource monsterScream;
    public GameObject guy;
    public GameObject monster;

    public bool hasPlayed = false;
    public int randomSoundCheck = 0;
    public float timerSet = 5f;
    // Start is called before the first frame update
    void Start()
    {
        monsterScream = GetComponent<AudioSource>();
        //monsterScream.pitch = pitch;
    }

    // Update is called once per frame
    void Update()
    {

        if (hasPlayed)
        {
            timerSet -= Time.deltaTime;
        }

        if (timerSet <= 0)
        {
            guy.SetActive(true);
            monster.SetActive(false);
            hasPlayed = false;
            timerSet = 5;
        }
    }

    private void FixedUpdate()
    {
        randomSoundCheck = Random.Range(0, 1000);
        if (randomSoundCheck == 60 && !hasPlayed)
        {
            MonsterSneeze();
            hasPlayed = true;
        }

    }

    private void MonsterSneeze()
    {
       monsterScream.Play();
        guy.SetActive(false);
        monster.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timebotton : MonoBehaviour
{
    public GameObject menudeperderGO;
    public GameObject menudeganarGO;
    public float time;
    private bool a;
    // Start is called before the first frame update
    void Start()
    {
        menudeperderGO.SetActive(false);
        menudeganarGO.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        times();

    }

    public void times()
    {
        if (time >= 0 /*&&*/) // pierde
        {
            a = true;
            Time.timeScale = 0.0f;
            menudeperderGO.SetActive(true);
        }

        if (time <= 0 /*&&*/) // gana // siempre deberia GANAR
        {
            a = true;
            Time.timeScale = 0.0f;
            menudeganarGO.SetActive(true);
        }

    }



}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timebotton : MonoBehaviour
{
    public float time;
    public GameObject CanvastimeGO;
    private bool pausedtime;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        times();
    }

    public void times()
    {
        if (time <= 0)
        {
            pausedtime = true;
            Time.timeScale = 0.0f;
            CanvastimeGO.SetActive(true);
        }

        else if (time >= 60)
        {
            pausedtime = true;
            Time.timeScale = 0.0f;
            CanvastimeGO.SetActive(true);
        }

        else
        {
            pausedtime = false;
            Time.timeScale = 1.0f;
            CanvastimeGO.SetActive(false);
        }
    }
}

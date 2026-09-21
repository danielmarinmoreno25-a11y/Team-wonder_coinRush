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
        time = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
            time -= Time.deltaTime;
            times();

        

    }

    public void times() // derrota victoria
    {

        if (menudeganarGO != null && menudeperderGO != null)
        {
            /*if (time <= 0 && …………) // pierde
            {
                a = false;
                Time.timeScale = 0.0f;
                menudeperderGO.SetActive(true);
            }
            else if (time >= 0 && …………) // gana
            {
                a = true;
                Time.timeScale = 0.0f;
                menudeganarGO.SetActive(true);
            }*/
        }

    }

}

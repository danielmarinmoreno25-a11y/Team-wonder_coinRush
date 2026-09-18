using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class uimanager : MonoBehaviour
{
    // Start is called before the first frame update
  
    public timebotton timer_script;
    public static uimanager Instance;
    public float current_time;
    public TMP_Text Timer;
    void Start()
    {
        Instance = this;
      
        timer_script = GetComponent<timebotton>();
    }

    // Update is called once per frame
    void Update()
    {
        current_time = timer_script.time;

        Timer.text = current_time.ToString();
    }
}

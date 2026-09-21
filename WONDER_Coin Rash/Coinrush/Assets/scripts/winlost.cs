using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winlost : MonoBehaviour
{
    // Start is called before the first frame update
   
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Has chocado con " + collision.gameObject.name);
    }

    public void ReintentarPerder()
    {
        SceneManager.LoadScene(1);// cargamos la escena 1, que es el juego y la cargamos en modo simple para no cargarla una encima de otra
        Time.timeScale = 1.0f; // activamos el tiempo
    }

    public void ExitPerder()
    {
       // a = true; // reanudamos
        Time.timeScale = 0.0f; // activamos el tiempo
        SceneManager.LoadScene(0);

    }

    public void ReintentarGanar()
    {
        SceneManager.LoadScene(1);// cargamos la escena 1, que es el juego y la cargamos en modo simple para no cargarla una encima de otra
        Time.timeScale = 1.0f; // activamos el tiempo
    }

    public void ExitGanar()
    {
       // a = true; // reanudamos
        Time.timeScale = 0.0f; // activamos el tiempo
        SceneManager.LoadScene(0);
    }
}

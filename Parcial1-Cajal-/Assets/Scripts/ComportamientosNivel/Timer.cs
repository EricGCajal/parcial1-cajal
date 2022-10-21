using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float tiempo = 0;
    public TMPro.TMP_Text TextoTiempo;
    public TMPro.TMP_Text TextoGameOver;

    void start()
    {
        TextoGameOver.text = " ";
    }

    private void Update()
    {
        tiempo -= Time.deltaTime;

        TextoTiempo.text = "Tiempo: " + tiempo.ToString("f0");

        if (tiempo < 0)
        {
            Time.timeScale = 0;
            TextoTiempo.text = "Tiempo: 0";
            TextoGameOver.text = "GAME OVER";

        }
    }
}

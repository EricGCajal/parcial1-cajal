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

    // Update is called once per frame
    private void Update()
    {
        tiempo -= Time.deltaTime;

        TextoTiempo.text = "Tiempo: " + tiempo.ToString("f0");
    }
}

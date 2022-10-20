using UnityEngine;
using UnityEngine.SceneManagement;

public class CaidaJugador : MonoBehaviour
{
    GameObject Jugador;

    void Start()
    {
        Jugador = GameObject.Find("Jugador");
    }

    void Update()
    {
        if (Jugador.transform.position.y < -5)
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
    }


}
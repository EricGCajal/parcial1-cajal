using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlJugador : MonoBehaviour
{
    private Rigidbody rb;
    public int rapidez;
    public TMPro.TMP_Text textoCantidadRecolectados;
    public TMPro.TMP_Text textoGanaste;
    public TMPro.TMP_Text textoGameOver;
    private int cont;
    GameObject Jugador;




    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cont = 0;
        textoGanaste.text = "";
        textoGameOver.text = "";
        setearTextos();
        Jugador = GameObject.Find("Jugador");



    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
            Time.timeScale = 1;
        }
    }

    private void setearTextos()
    {
        textoCantidadRecolectados.text = "Cantidad recolectados: " + cont.ToString();
        if (cont >= 5)
        {
            textoGanaste.text = "Ganaste!";
        }
 
    }

    private void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 vectorMovimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);

        rb.AddForce(vectorMovimiento * rapidez);


    }

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.CompareTag("coleccionable") == true) //Colisión con coleccionables
        {
            cont = cont + 1;
            setearTextos();
            other.gameObject.SetActive(false);
            transform.localScale = new Vector3(2f, 2f, 2f);
            rapidez *= 2;

        }

        if (other.gameObject.CompareTag("Enemigo") == true) //Colisión con enemigos
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
           
        }
    }

}

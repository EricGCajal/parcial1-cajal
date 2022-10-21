using UnityEngine;

public class Bot1 : MonoBehaviour
{

    private GameObject jugador;
    public int Velocidad;

    void Start()
    {

        jugador = GameObject.Find("Jugador");
    }

    private void Update()
    {
        transform.LookAt(jugador.transform);
        transform.Translate(Velocidad * Vector3.forward * Time.deltaTime);
    }

    private void desaparecer()
    {
        Destroy(gameObject);
    }

}


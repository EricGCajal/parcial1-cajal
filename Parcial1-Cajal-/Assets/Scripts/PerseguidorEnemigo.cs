using UnityEngine;

public class PerseguidorEnemigo : MonoBehaviour
{
    private int Vida;
    private GameObject jugador;
    public int Velocidad;

    void Start()
    {
        Vida = 100;
        jugador = GameObject.Find("Jugador");
    }

    private void Update()
    {
        transform.LookAt(jugador.transform);
        transform.Translate(Velocidad * Vector3.forward * Time.deltaTime);
    }

    public void recibirDaño()
    {
        Vida = Vida - 25;

        if (Vida <= 0)
        {
            this.desaparecer();
        }
    }

    private void desaparecer()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bala"))
        {
            recibirDaño();
        }
    }
}


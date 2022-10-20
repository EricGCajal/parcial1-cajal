using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JugadorSalto : MonoBehaviour

{
    public Rigidbody rb;
    public float Velocidad_Salto;
    private bool EnElSuelo = true;
    public int SaltosActuales = 0;
    public int SaltosMaximos = 2;
    
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (EnElSuelo || SaltosMaximos > SaltosActuales))
        {
            rb.velocity = new Vector3(0f, Velocidad_Salto, 0f * Time.deltaTime);
            rb.AddForce(Vector3.up * Velocidad_Salto, ForceMode.Impulse);
            EnElSuelo = false;
            SaltosActuales++;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        EnElSuelo = true;
        SaltosActuales = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Moves the object forward two units.
        transform.Translate(0, 0, 2);
    }

    // Update is called once per frame
    public float velocidad = 2;
    void Update()
    {
        // Moves the object forward at two units per second.
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }
}

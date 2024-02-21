using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dd : MonoBehaviour
{
    public float speed = 5.0f; // Velocidad de movimiento hacia adelante

    // Update is called once per frame
    void Update()
    {
        // Mueve el objeto hacia adelante constantemente a la velocidad definida
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}

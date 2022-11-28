using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Proyectil detecta colisiones y se destruye al animal y a sí mismo

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);  // Destruye el proyectil
        Destroy(other.gameObject);  // Destruye el animal con el que colisione
    }
}

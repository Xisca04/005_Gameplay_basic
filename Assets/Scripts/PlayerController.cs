using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f; // Velocidad del player
    private float horizontalInput;
    private float xRange = 15f; // Límites horizaontales del movimiento del player

    public GameObject projectilePrefab; //GameObject del projectile

    private void Update()
    {
        //Movimiento manual - jugador
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        //Llamada de la funcion para la posicion del jugador
        //Mantiene al player en la pantalla
        PlayerInBounds();

        //Llamada de la funcion del disparo del proyectil
        //Mecánica del disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireProjectile();
        }
    }

    // Función que mantiene al player dentro de los límites horizontales y verticales de la pantalla

    private void PlayerInBounds()
    {
        Vector3 pos = transform.position;
        if(pos.x < -xRange) //limite del borde horizontal de la izq.
        {
            transform.position = new Vector3(-xRange, pos.y, pos.z);
        }

        if(pos.x > xRange) //limite del borde horizontal de la dch.
        {
            transform.position = new Vector3(xRange, pos.y, pos.z);
        }
    }

    private void FireProjectile()
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity); //Disparo del proyectil
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private float horizontalInput;
    public float xRange = 15f;

    public GameObject projectilePrefab; //GameObject del projectile

    private void Update()
    {
        //Movimiento manual - jugador
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        //Llamda de la funcion para la posicion del jugador
        PlayerInBounds();

        //Llamada de la funcion del disparo del proyectil
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireProjectile();
        }
    }

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

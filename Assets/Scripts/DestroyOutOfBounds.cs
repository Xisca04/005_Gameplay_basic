using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //Destruccion animales y proyectiles

    private float upperLimit = 20f;
    private float lowerLimit = -10f;

    private void Update()
    {
        //LIMITE INFERIOR -> ANIMALES NO ALIMENTADO
        if(transform.position.z < lowerLimit)
        {
            Destroy(gameObject);
           
            //Mecánica del Game over
            Debug.Log($"GAME OVER");
            Time.timeScale = 0;
        }
        
        //LIMITE SUPERIOR -> BALA FALLIDA
        if(transform.position.z > upperLimit)
        {
            Destroy(gameObject);
        }
    }
}

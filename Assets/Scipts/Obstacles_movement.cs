using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles_movement : MonoBehaviour
{
    bool irPuntoA = true;
    bool irPuntoB = false;

    [SerializeField]
    Vector3 puntoA; 

    [SerializeField]
    Vector3 puntoB;

    float velocidad = 0.5f;


    void Update()
    {
        //Con los booleanos usar == y no hacerlo es lo mismo (en este caso preguntaría que es verdadero)
        //Si se pone un ! delante de un booleano preguntas lo contrario (en este caso preguntaría si es falso)
        if (irPuntoA)
        {
            transform.Translate(puntoB * Time.deltaTime * velocidad);
            irPuntoA = false;
            irPuntoB = true;

        }
        else if (irPuntoB)
        {
            transform.Translate(puntoA * Time.deltaTime * velocidad);
            irPuntoB = false;
            irPuntoA = true;
        }
    }
}

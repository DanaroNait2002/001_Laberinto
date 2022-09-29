using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles_Rotation : MonoBehaviour
{
    //Rotacion de los obstaculos
    [SerializeField]
    float rotationY = 50f;


    //Funcion de rotacion de los obtaculos
    void Update()
    {
        transform.Rotate(0.0f, rotationY * Time.deltaTime, 0.0f);
    }
}

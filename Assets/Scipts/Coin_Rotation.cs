using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Rotation : MonoBehaviour
{
    //Rotacion de las monedas
    [SerializeField]
    float rotationX = 50f;


    //Funcion de rotacion de las monedas
    void Update()
    {
        transform.Rotate(rotationX * Time.deltaTime, 0.0f, 0.0f);
    }
}


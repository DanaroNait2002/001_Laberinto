using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles_movement : MonoBehaviour
{
    [SerializeField]
    Vector3 pointA;
    [SerializeField]
    Vector3 pointB;
    float velocidad = 1.5f;


    // Update is called once per frame
    void Update()
    {
        if ( == )
        {
            transform.Translate(pointA * Time.deltaTime * velocidad);
        }

        if ( == )
        {
            transform.Translate(pointB * Time.deltaTime * velocidad);
        }
    }
            
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deteccion_Colision_Pared : MonoBehaviour
{
    //Material por defecto de las paredes
    [SerializeField]
    Material materialWalls;
    //Material de las paredes al detectar al jugador
    [SerializeField]
    Material MaterialDetector;

    //Contador para el color de la pared
    bool redWall = false;

    float redTime = 5f;

    //Tiempo para que las paredes sean de otro color
    private void Update()
    {
        if (redWall == true)
        {
            redTime = redTime - Time.deltaTime;
            if(redTime < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = materialWalls;
                redWall = false;
                redTime = 5f;
            }
        }
    }

    //Funcion que se ejecuta al colisionar con este gameObjetc
    private void OnCollisionEnter(Collision col)
    {   
        if (col.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material = MaterialDetector;
            redWall = true;
        }
    }

}

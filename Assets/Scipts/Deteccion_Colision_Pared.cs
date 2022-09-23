using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deteccion_Colision_Pared : MonoBehaviour
{
    [SerializeField]
    Material materialWalls;

    [SerializeField]
    Material MaterialDetector;

    bool redWall = false;

    float redTime = 5f;

    //funcion que se ejecuta por cada frame del juego
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Player : MonoBehaviour
{
    //Movimiento en los ejes
    public float movementX;
    public float movementY;
    public float movementZ;

    //Contador en 0 de monedas
    public int coins_Obtain = 0;

    //Valor de velocidad de movimiento
    public float velocidadMovimiento = 1.5f;


    void Update()
    {
        //Movimiento en dos ejes
        movementX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
        movementZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;
        transform.Translate(movementX,movementY,movementZ);
    }

        //Detector de monedas
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            coins_Obtain = coins_Obtain + 1;
            //Debug.Log(coins_Obtain    
        }
    }
}

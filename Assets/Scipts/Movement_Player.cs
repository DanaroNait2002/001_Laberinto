using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Player : MonoBehaviour
{
    public float movementX;
    public float movementY;
    public float movementZ;

    public float velocidadMovimiento = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Si llegase a pasar que uno de mis ejes esta invertido poner un menos delante de input y ya se soluciona
        movementX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
        movementZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;
        transform.Translate(movementX,movementY,movementZ);
    }
}

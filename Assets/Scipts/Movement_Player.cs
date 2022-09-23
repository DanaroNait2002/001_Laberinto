using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Player : MonoBehaviour
{
    public float movementX;
    public float movementY;
    public float movementZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        movement = Input.GetAxis("Horizontal");
        transform.Translate(movementX,movementY,movementZ);
    }
}

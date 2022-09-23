using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles_Rotation : MonoBehaviour
{
    [SerializeField]
    float rotationY = 50f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, rotationY * Time.deltaTime, 0.0f);
    }
}

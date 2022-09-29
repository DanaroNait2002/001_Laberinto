using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Deteccion_Meta : MonoBehaviour
{
    //Pantalla final
    [SerializeField]
    GameObject finalScreemWin;
    //Texto de tiempo al finalizar
    [SerializeField]
    TextMeshProUGUI textLabelTime;
    //Texto de monedas obtenidas
    [SerializeField]
    TextMeshProUGUI textLabelCoins;

    //Tiempo jugando
    float timeRun = 0.0f;
    bool playing = true;


    //Contador de tiempo mientras se esta jugando
    private void Update()
    {
        if (playing == true)
        {
            timeRun = timeRun + Time.deltaTime;
        }
    }

    //Activacion pantalla final
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            finalScreemWin.SetActive(true);
            other.GetComponent<Movement_Player>().enabled = false;
            int coins = other.GetComponent<Movement_Player>().coins_Obtain;
            playing = false;
            textLabelTime.text = timeRun.ToString();
            textLabelCoins.text = coins.ToString();
            

        }

    }

}

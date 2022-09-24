using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Deteccion_Meta : MonoBehaviour
{
    [SerializeField]
    GameObject finalScreemWin;

    [SerializeField]
    TextMeshProUGUI textLabelTime;

    float timeRun = 0.0f;
    bool playing = true;

    private void Update()
    {
        if (playing == true)
        {
            timeRun = timeRun + Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            finalScreemWin.SetActive(true);
            other.GetComponent<Movement_Player>().enabled = false;
            playing = false;
            textLabelTime.text = timeRun.ToString();
        }

    }

}

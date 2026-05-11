using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{

    public TextMeshProUGUI txt_perdiste;
    public TextMeshProUGUI txt_tiempo;
    private float tiempoTranscurrido = 0f;
    private bool contando = true;

    // Start is called before the first frame update
    void Start()
    {
        txt_perdiste.gameObject.SetActive(false);
        txt_tiempo.text = "Tiempo: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (contando)
        {
            tiempoTranscurrido += Time.deltaTime;
            txt_tiempo.text = "Tiempo: " + Mathf.FloorToInt(tiempoTranscurrido).ToString();
        }
    
    }
}

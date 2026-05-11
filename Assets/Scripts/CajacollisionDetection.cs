using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajacollisionDetection : MonoBehaviour
{
    private Vector3 posicionInicial;
     public float incrementoVelocidad = 0.5f;
    private CajaMovement cajaMovement;
    public UImanager ugui;
 
    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
         cajaMovement = GetComponent<CajaMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col){
        Debug.Log("Choco con " + col.gameObject.name);
        if(col.gameObject.CompareTag("Player"))
        {
            Destroy(col.gameObject);
            ugui.txt_perdiste.gameObject.SetActive(true);
        }else if(col.gameObject.CompareTag("piso"))
        
        {
            
            int[] posicionesX = { -2, 0, 2 };
            int xRandom = posicionesX[Random.Range(0, posicionesX.Length)];
            transform.position = new Vector3(xRandom, posicionInicial.y, posicionInicial.z);
            cajaMovement.speed += incrementoVelocidad;
            
        }
    }
}

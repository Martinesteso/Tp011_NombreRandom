using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -2){
            transform.Translate(-2, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 2){
            transform.Translate(2, 0, 0);
        }

    }
}

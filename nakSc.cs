﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nakSc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)

    {

        if (other.gameObject.CompareTag("hand")){

            gameObject.SetActive(false);

        }
        else{
            gameObject.SetActive(true);

        }

    }

}

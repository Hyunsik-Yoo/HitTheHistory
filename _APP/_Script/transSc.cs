using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transSc : MonoBehaviour
{

    public GameObject transBoxPrefab;


    void OnTriggerEnter(Collider other)

    {

        if (other.gameObject.CompareTag("Player"))

        {

            Destroy(gameObject);


        }



    }

    void newBox(){

        GameObject transBook = Instantiate(transBoxPrefab) as GameObject;
    }

    void Start()
    {
        Destroy(gameObject,1f);
    }
}

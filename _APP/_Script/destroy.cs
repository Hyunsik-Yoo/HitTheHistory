using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{

    public GameObject handModel;
    public GameObject transBoxPrefab;
    public static bool IsSmashed;
    public GameObject nakBox;


    void OnTriggerEnter(Collider other)

    {

        Debug.Log("TriggerEnter");

        IsSmashed = !IsSmashed;
        if (other.gameObject.CompareTag("Player"))

        {

            Destroy(handModel, 0.2f);
            Invoke("checkNak", 0.21f);

            Destroy(GameObject.FindWithTag("transbook"),0.25f);
            Invoke("deleteNak", 0.25f);
            Invoke("newBox", 0.26f);

         

        }



    }



    void Start()
    {

    }

    void newBox()
    {
        GameObject transBook = Instantiate(transBoxPrefab) as GameObject;
    }

    void checkNak(){

        nakBox.SetActive(true);
    }

    void deleteNak(){

        nakBox.SetActive(false);
    }
}

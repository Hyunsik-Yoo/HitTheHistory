using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour
{
    public GameObject handd;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))//
        {
            handd.GetComponent<Rigidbody>().mass=barSc.power*3;
            handd.GetComponent<Rigidbody>().useGravity = true;
        }

    }

  
}

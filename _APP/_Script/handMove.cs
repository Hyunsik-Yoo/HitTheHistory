using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handMove : MonoBehaviour


{
    public float speed = 3.0f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        gameObject.transform.Translate(Vector3.left * moveHorizontal * Time.deltaTime);
        gameObject.transform.Translate(Vector3.back * moveVertical * Time.deltaTime);
    }

}

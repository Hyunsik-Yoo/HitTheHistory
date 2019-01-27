using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hand : MonoBehaviour
{
    public GameObject handModel;
    private RaycastHit hit;
    public Text rayText;
    public static int count = 1;
    public float customPower = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void StartHandSwing()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if (Physics.Raycast(ray, out hit))
        {
            if(hit.transform.name == "mainBook")
            {
                barSc.speed = 0;
                GameObject hand = Instantiate(handModel, new Vector3(hit.point.x, hit.point.y + 9.5f, hit.point.z), Quaternion.identity);
                hand.tag = "hand";
                hand.GetComponent<Rigidbody>().mass = barSc.power * customPower;
                hand.GetComponent<Rigidbody>().useGravity = true;
                rayText.text = "명중!";
                count += 1;
            }
            rayText.text = "제대로 안맞고 " + hit.transform.name + "맞음";
        }
    }
}
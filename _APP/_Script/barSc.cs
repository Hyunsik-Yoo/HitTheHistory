using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barSc : MonoBehaviour


{
    public static float power = 0;
    public static float speed = 6;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        power += speed;

        if (power >= 418)
        {
            speed = -speed;
        }
        else if (power < 0)
        {
            speed = -speed;
        }

        GetComponent<RectTransform>().offsetMin = new Vector2(0, power);
        GetComponent<RectTransform>().offsetMax = new Vector2(0, power);
    }
}

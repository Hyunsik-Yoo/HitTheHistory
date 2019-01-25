using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BBtntest : MonoBehaviour
{
    public Button btn;

    // Start is called before the first frame update
    void Start(){
        btn.onClick.AddListener(Test);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Test(){
        Debug.Log("ssssss");
    }
}

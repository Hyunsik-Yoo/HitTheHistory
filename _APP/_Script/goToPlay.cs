using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToPlay : MonoBehaviour
{
    public GameObject introCanvas;
    public GameObject playCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void onClickStart()
    {
        introCanvas.SetActive(false);
        playCanvas.SetActive(true);
    }
}

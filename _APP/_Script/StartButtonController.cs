using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButtonController : MonoBehaviour
{
    public GameObject GameBoard;
    public Sprite activeButton;
    public Sprite inactiveButton;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameBoard.active)
        {
            Image theImage = GameObject.Find("StartButton").GetComponent<Image>();
            theImage.sprite = activeButton;
        }
        else
        {
            Image theImage = GameObject.Find("StartButton").GetComponent<Image>();
            theImage.sprite = inactiveButton;
        }
    }
}

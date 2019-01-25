using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class butImg : MonoBehaviour
{
    public Sprite handon;
    public Sprite handoff;
    public Button button;
    SpriteState spriteState = new SpriteState();


    void Start()
    {
        button = GetComponent<Button>();
        spriteState = button.spriteState;
    }




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroy : MonoBehaviour
{
    public GameObject transBoxPrefab;
    public GameObject mainBook;
    public static bool IsSmashed;
    public GameObject nakBox;
    public GameObject player2;
    public static int count = 1;
    public GameObject GameBoard;

    void OnTriggerEnter(Collider other)
    {
        IsSmashed = !IsSmashed;
        if (other.gameObject.CompareTag("hand"))
        {
            Destroy(other.gameObject, 0.1f);
            Invoke("checkNak", 0.11f);

            Destroy(GameObject.FindWithTag("transbook"), 0.25f);
            Invoke("resetTrans", 0.26f);
            Invoke("deleteNak", 0.27f);
            Invoke("resetHand", 2f);
        }
    }

    void Start()
    {
    }

    void resetTrans()
    {
        GameObject transBook = Instantiate(transBoxPrefab, GameBoard.transform);
        transBook.tag = "transbook";
    }

    void checkNak(){
        nakBox.SetActive(true);
    }

    void deleteNak(){
        nakBox.SetActive(false);
    }

    public void resetHand()
    {
        barSc.speed = 6;
        if (hand.count % 2 == 0)
        {
            player2.SetActive(true);
        }
        else
        {
            player2.SetActive(false);
        }
    }
}
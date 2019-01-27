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

    public GameObject coin1;
    public GameObject coin2;
    public GameObject coin3;
    public GameObject coin4;
    public GameObject coin5;

    void OnTriggerEnter(Collider other)
    {
        IsSmashed = !IsSmashed;
        if (other.gameObject.CompareTag("hand"))
        {
            coin1.transform.position = new Vector3(coin1.transform.position.x,
                                                    coin1.transform.position.y + 0.2f,
                                                    coin1.transform.position.z);

            coin2.transform.position = new Vector3(coin2.transform.position.x,
                                                    coin2.transform.position.y + 0.2f,
                                                    coin2.transform.position.z);

            coin3.transform.position = new Vector3(coin3.transform.position.x,
                                                    coin3.transform.position.y + 0.2f,
                                                    coin3.transform.position.z);

            coin4.transform.position = new Vector3(coin4.transform.position.x,
                                                    coin4.transform.position.y + 0.2f,
                                                    coin4.transform.position.z);

            coin5.transform.position = new Vector3(coin5.transform.position.x,
                                                    coin5.transform.position.y + 0.2f,
                                                    coin5.transform.position.z);

            Destroy(other.gameObject, 0.1f);
            Invoke("checkNak", 0.11f);

            Destroy(GameObject.FindWithTag("transbook"), 0.12f);
            Invoke("resetTrans", 0.13f);
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
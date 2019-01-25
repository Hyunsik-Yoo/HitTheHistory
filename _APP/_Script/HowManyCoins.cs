using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowManyCoins : MonoBehaviour
{
    public static bool[] coinUpStatus = new bool[5];
    public GameObject[] Coins = new GameObject[5];
    //public Text scoreTextFront;
    //public Text scoreTextBack;

    public static int gameScore;




    // Update is called once per frame
    void Update()
    {
        if (destroy.IsSmashed)
        {
            Debug.Log("Is Smashed");
            destroy.IsSmashed = !destroy.IsSmashed;
            Invoke("CheckCoinStatus", 2.5f);
            Invoke("ScoreIs", 3);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            CheckCoinStatus();
            ScoreIs();
        }

    }
    public void CheckCoinStatus()
    {

        Debug.Log("Counting coins");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(Coins[2].transform.up);
            if (Coins[i].transform.up.y > 0)
            {
                coinUpStatus[i] = true;
            }
            else
            {
                coinUpStatus[i] = false;
            }

            Debug.Log(coinUpStatus[0] + " , " + coinUpStatus[1] + " , " + coinUpStatus[2] + " , " + coinUpStatus[3] + " , " + coinUpStatus[4]);
        }
    }

    private void ScoreIs()
    {
        Debug.Log("Calculating score");
        int score = 0;
        for (int i = 0; i < coinUpStatus.Length; i++)
        {
            //Debug.Log(coinUpStatus[i]);
            if (coinUpStatus[i]) score++;
            //Debug.Log(i + " -> " + Coins[i].transform.eulerAngles.x);
        }
        //scoreTextFront.text = score.ToString();
        //scoreTextBack.text = (coinUpStatus.Length - score).ToString();

        gameScore = score;
        Debug.Log(score);

    }
    /*
    
    void OnDrawGizmos()
    {
        Color color;
        color = Color.green;
        // local up
        for (int i = 0; i < 5; i++)
        {
            DrawHelperAtCenter(Coins[i].transform.up, color, 2f);
        }

        color.g -= 0.5f;
        // global up
        //DrawHelperAtCenter(Vector3.up, color, 1f);

        color = Color.blue;
        // local forward
        for (int i = 0; i < 5; i++)
        {
            DrawHelperAtCenter(Coins[i].transform.forward, color, 2f);
        }
        color.b -= 0.5f;
        // global forward
        //DrawHelperAtCenter(Vector3.forward, color, 1f);

        color = Color.red;
        // local right
        for (int i = 0; i < 5; i++)
        {
            DrawHelperAtCenter(Coins[i].transform.right, color, 2f);
        }
        color.r -= 0.5f;
        // global right
        //DrawHelperAtCenter(Vector3.right, color, 1f);
    }
    private void DrawHelperAtCenter(
                   Vector3 direction, Color color, float scale)
    {
        Gizmos.color = color;
        Vector3 destination = transform.position + direction * scale;
        Gizmos.DrawLine(transform.position, destination);
    }
     */
}
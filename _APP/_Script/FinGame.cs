using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinGame : MonoBehaviour
{
    public Transform finGameBg;
    public GameObject UIgamePanel;
    public GameObject finGamePanel;
    public float rotSpeed = 10.0f;
    public static bool IsFirstRound;
    // Start is called before the first frame update
    void Awake()
    {
        finGamePanel.gameObject.SetActive(false);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            EndOfGame();
        }
    }
    void EndDetector()
    {
        if (HowManyCoins.gameScore == 5)
        {
            EndOfGame();
        }
        if(IsFirstRound){
            if(HowManyCoins.gameScore == 0){
                EndOfGame();
            }
        }
    }
    public void reload(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void EndOfGame()
    {
        finGamePanel.gameObject.SetActive(true);
        UIgamePanel.gameObject.SetActive(false);
        StartCoroutine(RotateMe(finGameBg, new Vector3(0, 0, 830)));
    }

    Coroutine co;
    public void Rotate(Transform ObjToRotate)
    {
        if (co == null)
            co = StartCoroutine(RotateMe(ObjToRotate, Vector3.forward * 90));
    }

    Quaternion toAngle;
    IEnumerator RotateMe(Transform rotateobj, Vector3 byAngles)
    {
        toAngle = Quaternion.Euler(rotateobj.transform.eulerAngles + byAngles);
        while (rotateobj.transform.rotation != toAngle)
        {
            rotateobj.transform.rotation = Quaternion.RotateTowards(rotateobj.transform.rotation, toAngle, 0.5f);
            yield return null;
        }
    }
}
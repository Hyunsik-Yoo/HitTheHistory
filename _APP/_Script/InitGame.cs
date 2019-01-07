using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitGame : MonoBehaviour
{
    public GameObject GameBoard;
    public GameObject BaseGround;
    //AR 코드를 아직 못들여다봤어요.. COllider를 주거나 해서 ray out hit.point 검출 예정

    // Start is called before the first frame update
    void Awake(){
        // Load AR Cam & Initialize
    }
    void Start()
    {
        Debug.Log("마지막 수정 : 2018. 12.29");
    }

    // Update is called once per frame
    void Update()
    {
        //Get User Input from Keyboard for debugging
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("clicked!");
            SpawnGameBoard();
        }
        /* */
        if(Input.touchCount>0){
            if(Input.GetTouch(0).phase == TouchPhase.Began){
                Debug.Log("You just touched me!");
                SpawnGameBoard();
            }
        }
    }

    void SpawnGameBoard(){
        RaycastHit hit;
        
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //디버깅용, 신경쓰지마세요

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        //뷰포트에서 수직으로 월드에 ray를 쏘는거래요
        //뷰포트 좌측 하단은 0,0 우측 상단은 1,1 따라서 가운데는 0.5, 0.5

        if(Physics.Raycast(ray, out hit)){
            print("I'm Looking at " + hit.transform.name);
            Debug.Log("hit"+ hit.point);
            Instantiate(GameBoard, hit.point, Quaternion.identity);
            //회전값 플레인 노말값에서 추출 필요

            
        }else{
            print("I'm Looking at nothing!");
        }
    }
}

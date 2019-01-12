using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDetector : MonoBehaviour {
	public static bool[] coinUpStatus;

	public GameObject[] Coins = new GameObject[5];
	
	void CheckCoinStatus(){
		for(int i = 0; i < 5; i++){
			if(Coins[i].transform.rotation.x >= -90 && Coins[i].transform.rotation.x < 90){ // 앞면 확인 필요
                coinUpStatus[i] = true;

			}else if(Coins[i].transform.rotation.z >= -90 && Coins[i].transform.rotation.z < 90){
                coinUpStatus[i] = true;
			}else{
				coinUpStatus[i] = false;
			}
		}
	}
	private static int ScoreIs(bool[] coinUpStatus){
		int score = 0;
		for(int i=0; i < coinUpStatus.Length; i++){
			if(coinUpStatus[i]) score++;
		}
		return score;
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfTest : MonoBehaviour {

    // Use this for initialization
    void Start() {
        //moneyを200で初期化する
        int money = 200;

        if (money >= 100)
        {
            //moneyの値が100以上の場合、文字列を表示する
            Debug.Log ("ポーションを買う");

        }
        else
        {
            //moneyが100未満だった場合
            Debug.Log("武器を売る");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

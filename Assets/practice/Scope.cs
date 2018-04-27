using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //変数aを3で初期化する
        int a = 3;
        if( a == 3)
        {
            //変数aが3の場合変数bを5で初期化する
            int b = 5;
            //変数bの値を表示する
            Debug.Log(b);
        }
	}


	// Update is called once per frame
	void Update () {
		
	}
}

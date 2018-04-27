using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // 要素数5の配列を初期化する
        string[] points = new string[5];

        // 配列の各要素に値を代入する
        points[0] = "もみじ";
        points[1] = "かえで";
        points[2] = "クローバー";
        points[3] = "三つ葉";
        points[4] = "葦";

        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //コンソールに"Hello, World"と表示   課題1
        Debug.Log("Hello, Wolrd");

        //変数の宣言                         課題2
        int score;
        //変数の代入
        score = 150;
        //コンソールに変数の中身を表示
        Debug.Log(score);

        //変数を初期化する
        int a = 3;
        int b = 4;
        //変数aと変数bの合計値を変数cに代入する
        int c = a + b;
        //変数cを表示する
        Debug.Log(c);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

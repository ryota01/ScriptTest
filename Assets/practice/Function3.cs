using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function3 : MonoBehaviour {

    // 第一引数と第二引数と第三引数をの値を足した値を返す関数(練習)
    int Add(int a, int b, int c)
    {
        // 第一引数と第二引数と第三引数の値を足して、変数dに代入する
        int d = a + b + c;
        // 変数dを呼び出し元の関数に返す
        return d;
    }

	// Use this for initialization
	void Start () {
        //Add関数に「3」と「6」と「9」の引数を渡し、返り値をnum変数に代入する
        int num = Add(3, 6, 9);
        //numを表示する
        Debug.Log(num);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

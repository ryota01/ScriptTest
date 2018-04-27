using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Theme1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // 配列を初期化する
        int[] array = {10, 20, 30, 40, 50};

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = 0; i < array.Length; i++)
        {
            // 配列の要素を表示する
            Debug.Log(array[i]);
        }

        // for文を使って配列の各要素の値を逆順で表示
        for (int i = array.Length - 1; i >= 0; i--)
        {
            // 配列の要素を表示する
            Debug.Log(array[i]);
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

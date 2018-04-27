using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Total : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // sumを0で初期化する
        int sum = 0;
        // 10回処理を繰り返す
        for (int i = 1; i <= 10; i++)
        {
            // iの値をsumに足す
            sum += i;
        }
        // sumの値を表示する
        Debug.Log(sum);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

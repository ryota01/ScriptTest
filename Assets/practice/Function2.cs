using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function2 : MonoBehaviour {

    //「Hello」に続けて引数の文字列を表示する関数
    void HelloName(string name)
    {
        Debug.Log("Hello, " + name);
    }

    // Use this for initialization
    void Start () {
        // HelloName関数に「Unity」という引数を渡す
        HelloName("Unity");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

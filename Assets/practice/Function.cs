using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour {

    // 「Hello, Unitychan」と表示する関数
    void Hello()
    {
        Debug.Log("Hello, Unitychan");
    }

    void Goodbye()
    {
        Debug.Log("Goodbye, Unitychan");
    }
    
	// Use this for initialization
	void Start () {
        // Hello関数を呼び出す
        Hello();

        // Goodbye関数を呼び出す
        Goodbye();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

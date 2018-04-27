using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//5回処理を繰り返す
        for (int f = 0; f < 7; f++)
        {
            Debug.Log(f);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

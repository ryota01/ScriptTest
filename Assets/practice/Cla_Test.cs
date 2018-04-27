using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cla_Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        // Bossクラスのmidboss変数を作り、Attack関数とDefence関数を呼び出す
        Boss midboss = new Boss();

        // 攻撃用の関数を呼び出す
        midboss.Attack();
        // 防御用の関数を呼び出す
        midboss.Defence(5);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

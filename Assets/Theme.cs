﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Boss
    {
    private int hp = 100;                   //体力
    private int power = 25;                 //攻撃力
    private int mp = 53;                    //魔力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    // 魔法用の関数
    public void Magic(int a)
    {
            if (mp >= a)
            {
                // mpがa以上だった場合、mpをa減らす
                mp -= a;
                // 表示する
                Debug.Log("魔法攻撃をした。残りMPは " + mp);
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
        }
    }

    public class Theme : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        Debug.Log("通常課題");

        // 配列を初期化する
        int[] array = { 10, 20, 30, 40, 50 };

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

        Debug.Log("発展課題");

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        // 魔法用の関数を11回呼び出す
        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic(5);
        }

    }
        // Update is called once per frame
        void Update()
        {

        }
    }
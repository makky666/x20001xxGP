using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotion : MonoBehaviour
{
    //Animatoe型を変数animで宣言します。
    private Animator anim;
  

    void Start()
    {
        //GetComponentでAnimatorを取得して変数animで参照します。
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //もしInputされている０(マウスの左クリック)が押された時の処理。
        if (Input.GetMouseButtonDown(0))
        {
            //Boolで設定したAttackをtrueにして再生します。
            anim.SetBool("Attack", true);
        }
        
    }
}
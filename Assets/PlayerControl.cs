using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerControl : MonoBehaviour
{
    public float forwardSpeed = 2.0f; // 前進速度
    public float rotationSpeed = 100.0f; // 回転速度
    private Animator anim; //Animator型変数宣言
    private bool runFlg;
     public Collider attackCollider;  

    void Start()
    {
        anim = GetComponent<Animator>(); //このスクリプトがアサインされたキャラクターのアニメーターコントローラーを取得
    }
    void Update()
    {
        float v = Input.GetAxis("Vertical"); //上下キーの取得 Up:1, Down:-1　に段階的に変化
        float h = Input.GetAxis("Horizontal"); //左右キーの取得 Right:-1 Left:1　に段階的に変化
        if (v > 0.1 || v < -0.1 || h > 0.1 || h < -0.1)
        {
            runFlg = true;
        }
        else
        {
            runFlg = false;
        }
        anim.SetBool("Walk", runFlg); //アニメーターコントローラーのRunに値(runFlg)を代入
        transform.position += transform.forward * forwardSpeed * v * Time.deltaTime; //プレイヤーを移動
        transform.Rotate(0, rotationSpeed * h * Time.deltaTime, 0); //プレイヤーを回転

           if (Input.GetMouseButtonDown(0))
        {
            
            anim.SetBool("Attack",true);    //マウスクリックで攻撃モーション
        }
    }
      public void OffColliderAttack()
    {
        attackCollider.enabled = false;
    }
    public void OnColliderAttack()
    {
        attackCollider.enabled = true;
    }

    
}
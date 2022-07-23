using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class RandomWalk1 : MonoBehaviour
{
    private float chargeTime = 5.0f;
    private float timeCount;
     private Animator anim;  

     void Start()
    {
        anim = GetComponent<Animator>(); //このスクリプトがアサインされたキャラクターのアニメーターコントローラーを取得
        
    }

    void Update()
    {
        timeCount += Time.deltaTime;
 
        // 自動前進
        transform.position += transform.forward * Time.deltaTime;
         anim.SetBool("Walk", true);
        // 指定時間の経過（条件）
        if(timeCount > chargeTime)
        {
            // 進路をランダムに変更する
            Vector3 course = new Vector3(0, Random.Range(0, 180), 0);
            transform.localRotation = Quaternion.Euler(course);
 
            // タイムカウントを０に戻す
            timeCount = 0;
            anim.SetBool("Walk", false);
        }
    }
}
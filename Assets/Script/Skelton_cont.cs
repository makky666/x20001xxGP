using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skelton_cont : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;
    public GameObject breakEffect;
    private Animator anim; 
    GameObject gm;  

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find ("GameManager1"); ;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    
    private void OnTriggerEnter(Collider other)
    {
        SoundManager.Instance.PlaySE(SESoundData.SE.Damage);
       Destroy(gameObject);
        GenerateEffect();
        gm.GetComponent<GameManager1> ().DecreaseLife(); 
    }

    //エフェクトを生成する
    void GenerateEffect()
    {
        SoundManager.Instance.PlaySE(SESoundData.SE.Destory);

        //エフェクトを生成する
        GameObject effect = Instantiate(breakEffect) as GameObject;
        //エフェクトが発生する場所を決定する(敵オブジェクトの場所)
        effect.transform.position = gameObject.transform.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skelton_cont : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;
    public GameObject breakEffect;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    
    private void OnTriggerEnter(Collider other)
    {
       Destroy(gameObject);
        GenerateEffect();

    }

    //エフェクトを生成する
    void GenerateEffect()
    {
        //エフェクトを生成する
        GameObject effect = Instantiate(breakEffect) as GameObject;
        //エフェクトが発生する場所を決定する(敵オブジェクトの場所)
        effect.transform.position = gameObject.transform.position;
    }
}

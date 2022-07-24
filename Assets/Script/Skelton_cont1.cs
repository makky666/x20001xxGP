using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skelton_cont1 : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;
    public GameObject breakEffect;
    private Animator anim; 
    GameObject gm;  

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find ("GameManager2"); ;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    
    private void OnTriggerEnter(Collider other)
    {
       Destroy(gameObject);
        GenerateEffect();
        gm.GetComponent<GameManager2> ().DecreaseLife(); 
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

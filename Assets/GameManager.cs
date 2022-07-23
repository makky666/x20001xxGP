using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject EnemyP; 
    public GameObject KnightP; 

    // Start is called before the first frame update
    void Start()
    {
        GameObject Knight = Instantiate(KnightP);
        for(int i=0;i<4;i++){
            GameObject Enemy = Instantiate(EnemyP);
            Enemy.transform.position=new Vector3(Random.Range(-8f,8f),0.375f,Random.Range(-8f,8f));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

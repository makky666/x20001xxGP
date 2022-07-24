using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public GameObject EnemyP; 
    public GameObject EnemyV; 
    public GameObject targetObject; // 注視したいオブジェクトを事前にInspectorから入れておく
    GameObject EnemyText;
    int Enemy=13;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<6;i++){
            GameObject Enemy = Instantiate(EnemyP);
            Enemy.transform.position=new Vector3(Random.Range(-15f,15f),0.375f,Random.Range(-13f,13f));
        }
        for(int i=0;i<7;i++){
                    GameObject Enemy = Instantiate(EnemyV);
                    Enemy.transform.position=new Vector3(Random.Range(-15f,15f),0.375f,Random.Range(-15f,13f));
                }
        EnemyText = GameObject.Find("EnemyCount");
        this.EnemyText.GetComponent<Text> ().text = "EnemyCount : " + Enemy;
    }
    void Update () {
        this.transform.LookAt(targetObject.transform);
                if (Enemy == 0) {
                SceneManager.LoadScene ("End");
            }
             if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene ("Title");
        
        } 
    }

    public void DecreaseLife(){
            Enemy--;
            this.EnemyText.GetComponent<Text> ().text = "EnemyCount : " + Enemy;

    }
}

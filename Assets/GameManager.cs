using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject EnemyP; 
    public GameObject targetObject; // 注視したいオブジェクトを事前にInspectorから入れておく
    GameObject EnemyText;
    int Enemy=5;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<5;i++){
            GameObject Enemy = Instantiate(EnemyP);
            Enemy.transform.position=new Vector3(Random.Range(-8f,8f),0.375f,Random.Range(-8f,8f));
        }

        EnemyText = GameObject.Find("EnemyCount");
        this.EnemyText.GetComponent<Text> ().text = "EnemyCount : " + Enemy;
    }
    void Update () {
        this.transform.LookAt(targetObject.transform);
                    if (Enemy == 0) {
                SceneManager.LoadScene ("Title");
            }
    }

    public void DecreaseLife(){
            Enemy--;
            this.EnemyText.GetComponent<Text> ().text = "EnemyCount : " + Enemy;

    }
}

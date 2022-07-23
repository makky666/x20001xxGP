using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
using UnityEngine.UI;  // 追加しましょう
 
public class ScoreManager : MonoBehaviour {
 
    public GameObject time_object = null; // Textオブジェクト
    public int time_num = 0; // スコア変数
    public static float timer=0;
    // 初期化時の処理
    void Start ()
    {
        timer=0;
        // スコアのロード
        time_num = PlayerPrefs.GetInt ("TIME", 0);
    }
    // 削除時の処理
    void OnDestroy(){
        // スコアを保存
        PlayerPrefs.SetInt ("TIME", time_num);
        PlayerPrefs.Save ();
    }
 
    // 更新
    void Update ()
    {
        timer += Time.deltaTime;

        // オブジェクトからTextコンポーネントを取得
        Text time_text = time_object.GetComponent<Text> ();
        // テキストの表示を入れ替える
        time_text.text = "Time:" + timer.ToString("f2");
 
        time_num += 1; // とりあえず1加算し続けてみる
    }

    public static float gettime(){
        return timer;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRotation : MonoBehaviour
 {
 
  public GameObject targetObject; // 注視したいオブジェクトを事前にInspectorから入れておく
 
    // Update is called once per frame
    void Update () {
        this.transform.LookAt(targetObject.transform);
    }
}
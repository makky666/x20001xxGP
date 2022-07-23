using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skelton_cont : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    
    private void OnTriggerEnter(Collider other)
    {
       Destroy(gameObject);
    }
}

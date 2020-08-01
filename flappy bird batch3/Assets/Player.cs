using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpforce;
    private Animator animator;
    float score;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            rb.velocity = Vector2.up *jumpforce;
        }
    }
    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.tag=="score"){
            score++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        animator.enabled = false;
    }
}

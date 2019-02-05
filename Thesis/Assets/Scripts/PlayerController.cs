﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpForce;
    private Rigidbody2D myRigidbody;
    private bool grounded;
    public LayerMask whatIsGround;
    private BoxCollider2D myCollider;
    public GameObject playerSword;
    private Animator myAnimator;

	// Use this for initialization
	void Start () {

        myCollider = GetComponent<BoxCollider2D>();
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);
        myAnimator.SetBool("Ground", grounded);
        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);

        // Player jumps when X button is clicked
        if (grounded && Input.GetMouseButtonDown(0))
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);

        myAnimator.SetFloat("Speed", myRigidbody.velocity.x);
        myAnimator.SetFloat("vSpeed", myRigidbody.velocity.y);

        //Player attacks when A button is clicked
        if (grounded && Input.GetKeyDown(KeyCode.Space))
            StartCoroutine(Attack());
    }

    public IEnumerator Attack()
    {
        playerSword.SetActive(true);
        myAnimator.SetTrigger("Attack");
        yield return new WaitForSeconds(.5f);
        playerSword.SetActive(false);
    }


}

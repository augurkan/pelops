﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    Animator anim;
    int isWalkingHash, isWalkingBackHash, isLeftHash, isRightHash;
    private CharacterController _controller;
    public float moveSpeed=10;

    //AudioSource audioSource;

    void Start()
    {
        anim = GetComponent<Animator>();
        _controller = GetComponent<CharacterController>();

        isWalkingHash = Animator.StringToHash("isWalking");

        isWalkingBackHash = Animator.StringToHash("isBack");
        isLeftHash = Animator.StringToHash("isLeft");
        isRightHash = Animator.StringToHash("isRight");

        //audioSource = gameObject.GetComponent<AudioSource>();

    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        Vector3 playerMovementVer = transform.forward * ver * moveSpeed * Time.deltaTime;
        Vector3 playerMovementHor = transform.right * hor * moveSpeed * Time.deltaTime;

        Vector3 playerMovement = playerMovementVer + playerMovementHor;
        _controller.Move(playerMovement);

        bool isWalking = anim.GetBool(isWalkingHash);
        bool isWalkingBack = anim.GetBool(isWalkingBackHash);
        

        bool forwardPressed = Input.GetKey("w");
        bool backwardPressed = Input.GetKey("s");
        bool leftPressed = Input.GetKey("a");
        bool rightPressed = Input.GetKey("d");

        #region Walking

        if (!isWalking && forwardPressed)
        {
            anim.SetBool(isWalkingHash, true);

            FindObjectOfType<AudioManager>().Play("Walking");
        }

        if (isWalking && !forwardPressed)
        {
            anim.SetBool(isWalkingHash, false);

            FindObjectOfType<AudioManager>().Stop("Walking");
        }

        #endregion

        #region Backwards

        if (!isWalkingBack && backwardPressed)
        {
            anim.SetBool(isWalkingBackHash, true);
            
        }

        if (isWalkingBack && !backwardPressed)
        {
            anim.SetBool(isWalkingBackHash, false);
        }

        #endregion

        #region Left

        if (!isWalking && leftPressed)
        {
            anim.SetBool(isLeftHash, true);
        }

        if (!leftPressed)
        {
            anim.SetBool(isLeftHash, false);
        }

        #endregion

        #region Right

        if (!isWalking && rightPressed)
        {
            anim.SetBool(isRightHash, true);
        }

        if (!rightPressed)
        {
            anim.SetBool(isRightHash, false);
        }

        #endregion

        

    }
}

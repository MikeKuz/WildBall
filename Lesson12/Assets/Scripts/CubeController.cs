using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CubeController : MonoBehaviour
{
    public int nextAnim;
    Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
    }


    public void ChangeAnim()
    {
        System.Random rnd = new System.Random();
        nextAnim = rnd.Next(1, 4);
        animator.SetInteger("NextAnim", nextAnim);
    }

}


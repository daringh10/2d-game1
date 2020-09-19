using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack2 : MonoBehaviour
{
    private bool attacking = false;

    private float attackTimer = 0f;
    private float attackCd = .5f;

    public Collider2D attackTrigger2;

    private Animator anim;

  

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        attackTrigger2.enabled = false;


    }

    
    void Update()
    {



        if (Input.GetKeyDown("c") && !attacking && Input.GetAxisRaw("Horizontal") !=0 || Input.GetButtonDown("Fire3") && !attacking && Input.GetAxisRaw("Horizontal") != 0)
        {
            attacking = true;
            attackTimer = attackCd;

            attackTrigger2.enabled = true;


        }

        if (attacking)
        {
            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
                attackTrigger2.enabled = false;
            }
        }









        anim.SetBool("Attacking2", attacking);
    }





}


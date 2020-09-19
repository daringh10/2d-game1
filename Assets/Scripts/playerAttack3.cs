using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack3 : MonoBehaviour
{
    private bool attacking = false;

    private float attackTimer = 0f;
    private float attackCd = .6f;

    public Collider2D attackTrigger3;

    private Animator anim;

    public Rigidbody RB;





    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        attackTrigger3.enabled = false;
        RB = GetComponent<Rigidbody>();


    }


    void Update()
    {



        if (Input.GetKeyDown("q") && !attacking || Input.GetButtonDown("Fire10") && !attacking )
        {
            attacking = true;
            attackTimer = attackCd;
            RB.velocity = Vector3.zero;


            attackTrigger3.enabled = true;


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
                attackTrigger3.enabled = false;
            }
        }









        anim.SetBool("Attacking3", attacking);
    }





}


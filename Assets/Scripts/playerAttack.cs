using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    private bool attacking = false;

    private float attackTimer = 0f;
    private float attackCd = .3f;

    public Collider2D attackTrigger1;

    private Animator anim;

   

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        attackTrigger1.enabled = false;


    }

    void Update()
    {



        if(Input.GetKeyDown("c") && !attacking && Input.GetAxisRaw("Horizontal") == 0 || Input.GetButtonDown("Fire3")  && !attacking && Input.GetAxisRaw("Horizontal") == 0)
        {
            attacking = true;
            attackTimer = attackCd;

            attackTrigger1.enabled = true;

            
        }

        if (attacking)
        {
            if(attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
                attackTrigger1.enabled = false;
            }
        }

       







        anim.SetBool("Attacking", attacking);
    }

    



}

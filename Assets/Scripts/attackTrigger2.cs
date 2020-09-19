﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackTrigger2 : MonoBehaviour
{
    public int dmg = 20;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.isTrigger != true && col.CompareTag("Enemy"))
        {
            col.SendMessageUpwards("Damage", dmg);
        }

    }

}
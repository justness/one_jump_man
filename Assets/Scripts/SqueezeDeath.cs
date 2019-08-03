﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SqueezeDeath : MonoBehaviour
{
    private Collider2D col;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D  other)
    {
        if (!other.isTrigger) {
            GetComponentInParent<PlayerController>().Die();
            Debug.Log("Squeeze!");
        }
    }
}

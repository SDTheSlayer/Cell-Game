﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider) {

        if (collider.gameObject.tag == "Player Cell")
        {
            Destroy(collider.gameObject);
            Destroy(this.gameObject);
        }
    }
}
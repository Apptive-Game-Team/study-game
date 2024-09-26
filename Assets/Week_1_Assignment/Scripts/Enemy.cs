using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    Transform enemyTransform;
    Vector3 moveDir;
    float moveSpeed = 1f;

    private void Start()
    {
        enemyTransform = GameObject.Find("Character").transform;
    }

    void Update()
    {
        moveDir = enemyTransform.position - transform.position;
        transform.position += moveDir * moveSpeed * Time.deltaTime;
    }
}

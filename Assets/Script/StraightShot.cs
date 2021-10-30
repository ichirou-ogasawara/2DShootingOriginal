using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightShot : MoveEnemyBullet
{
    // Start is called before the first frame update
    void Start()
    {
        bulletRB = this.gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        bulletRB.velocity = new Vector2(0, -1) * this.bulletSpeed;
    }
}

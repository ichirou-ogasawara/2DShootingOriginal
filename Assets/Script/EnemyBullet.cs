using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : Bullet // BulletÉNÉâÉXÇåpè≥
{
    // Start is called before the first frame update
    void Start()
    {
        bulletRB = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bulletRB.velocity = new Vector2(0, -1) * this.bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            collision.gameObject.GetComponent<SpaceShip>().Hit(atk);
        }
    }
}

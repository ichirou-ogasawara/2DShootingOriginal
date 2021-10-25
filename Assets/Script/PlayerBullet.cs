using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : Bullet // BulletÉNÉâÉXÇåpè≥
{
    private void Awake()
    {
    
    }
    // Start is called before the first frame update
    void Start()
    {
        bulletRB = this.gameObject.GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bulletRB.velocity = new Vector2(0, 1) * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("EnemyBullet"))
        {
            //BulletGenerator.instance.bulletPool.ReturnObject(gameObject);
        }

        else if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            collision.gameObject.GetComponent<SpaceShip>().Hit(atk);
            //BulletGenerator.instance.bulletPool.ReturnObject(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRed : SpaceShip // êÌì¨ã@ÉNÉâÉXÇåpè≥
{
    // Start is called before the first frame update
    void Start()
    {
        spaceShipRB = this.gameObject.GetComponent<Rigidbody2D>();
        currentSpeed = maxSpeed;
        ResetHp();
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemyRed();

        if (transform.position.y < -5 || this.currentHp <= 0)
        {
            DestroyEnemy();
        }
    }

    void MoveEnemyRed()
    {
        spaceShipRB.velocity = new Vector2(0, 1) * -1 * currentSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            collision.gameObject.GetComponent<SpaceShip>().Hit(bodyAtk);
        }
    }
    public void DestroyEnemy()
    {
        EnemySpawner.instance.enemyRedPool.ReturnObj(gameObject);
        ResetHp();
    }
}

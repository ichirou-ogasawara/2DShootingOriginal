using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : SpaceShip
{

    public void DestroyEnemy()
    {
        EnemySpawner.instance.enemyRedPool.ReturnObj(gameObject);
        ResetHp();
    }

    protected void MoveStraight()
    {
        spaceShipRB.velocity = new Vector2(0, 1) * -1 * moveSpeed;
    }
}

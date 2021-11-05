using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : SpaceShip
{
    protected Vector2 moveSidePos; // åpè≥êÊÇÃstartä÷êîì‡Ç≈transform.positionÇë„ì¸
    [SerializeField] protected float moveSideRange = 6.0f;

    [SerializeField] protected float addScore; // åÇîjéûÇÃâ¡ì_

    public void DestroyEnemy()
    {
        EnemySpawner.instance.enemyRedPool.ReturnObj(gameObject);
        ResetHp();
    }

    protected void MoveStraight()
    {
        spaceShipRB.velocity = new Vector2(0, 1) * -1 * moveSpeed;
    }

    protected void MoveSide()
    {
        float T = 1.0f;
        float f = 0.2f / T;
        transform.position = new Vector2(Mathf.Sin(2 * Mathf.PI * f * Time.time) * moveSideRange + moveSidePos.x, moveSidePos.y);
    }

    protected void GetItemAndScore()
    {
        UIController.score += addScore;
        GameObject.Find("ItemGenerator").GetComponent<ItemDroper>().DropItem(this.gameObject, 10);
    }
}

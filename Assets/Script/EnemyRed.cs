using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRed : Enemy // SpaceShipÉNÉâÉXÇåpè≥
{
    // Start is called before the first frame update
    void Start()
    {
        spaceShipRB = this.gameObject.GetComponent<Rigidbody2D>();
        ResetHp();
    }

    // Update is called once per frame
    void Update()
    {
        MoveStraight();

        if (transform.position.y < -movableRangeY)
        {
            DestroyEnemy();
        }
        else if (this.currentHp <= 0)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            DestroyEnemy();
            GetItemAndScore();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            collision.gameObject.GetComponent<SpaceShip>().Hit(bodyAtk);
        }
    }
}

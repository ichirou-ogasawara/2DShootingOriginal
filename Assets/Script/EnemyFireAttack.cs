using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireAttack : Bullet // BulletÉNÉâÉXÇåpè≥
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            collision.gameObject.GetComponent<SpaceShip>().Hit(bulletAtk);
        }
    }
}

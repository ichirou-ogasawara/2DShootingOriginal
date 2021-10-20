using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRed : SpaceShip
{
    new float hp = 1;
    new float atk = 1;
    private Rigidbody2D enemyRed;
    [SerializeField] private float moveSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        enemyRed = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemyRed();
    }

    public void MoveEnemyRed()
    {
        enemyRed.velocity = new Vector2(0, 1) * -1 * moveSpeed;
    }
}

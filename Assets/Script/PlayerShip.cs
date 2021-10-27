using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : SpaceShip // SpaceShipクラスを継承
{
    private float countDown;
    // Start is called before the first frame update
    void Start()
    {
        spaceShipRB = GetComponent<Rigidbody2D>(); // rigidbody2dコンポーネントを取得
        ResetHp();
    }

    void Update()
    {
        MovePlayer();

        if (this.currentHp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void MovePlayer()
    {
        this.spaceShipRB.velocity = new Vector2(0,0);

        if ((TouchController.touchInput.x > 0) && (this.transform.position.x < this.movableRangeX))
        {
            spaceShipRB.velocity = new Vector2(this.currentSpeed, spaceShipRB.velocity.y); // 右に移動
            SlowDown();
        }
        else if ((TouchController.touchInput.x < 0) && (-this.movableRangeX < this.transform.position.x))
        {
            spaceShipRB.velocity = new Vector2(-this.currentSpeed, spaceShipRB.velocity.y); // 左に移動
            SlowDown();
        }

        if ((TouchController.touchInput.y > 0) && (this.transform.position.y < this.movableRangeY))
        {
            spaceShipRB.velocity = new Vector2(spaceShipRB.velocity.x, this.currentSpeed); // 上に移動
            SlowDown();
        }
        else if ((TouchController.touchInput.y < 0) && (-this.movableRangeY < this.transform.position.y))
        {
            spaceShipRB.velocity = new Vector2(spaceShipRB.velocity.x, -this.currentSpeed); // 下に移動
            SlowDown();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            collision.gameObject.GetComponent<SpaceShip>().Hit(this.bodyAtk);
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Item"))
        {
            //collision.gameObject.GetComponent<Item>().ItemEffect();
        }
    }


}

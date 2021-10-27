using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : SpaceShip // SpaceShip�N���X���p��
{
    private float countDown;
    // Start is called before the first frame update
    void Start()
    {
        spaceShipRB = GetComponent<Rigidbody2D>(); // rigidbody2d�R���|�[�l���g���擾
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
            spaceShipRB.velocity = new Vector2(this.currentSpeed, spaceShipRB.velocity.y); // �E�Ɉړ�
            SlowDown();
        }
        else if ((TouchController.touchInput.x < 0) && (-this.movableRangeX < this.transform.position.x))
        {
            spaceShipRB.velocity = new Vector2(-this.currentSpeed, spaceShipRB.velocity.y); // ���Ɉړ�
            SlowDown();
        }

        if ((TouchController.touchInput.y > 0) && (this.transform.position.y < this.movableRangeY))
        {
            spaceShipRB.velocity = new Vector2(spaceShipRB.velocity.x, this.currentSpeed); // ��Ɉړ�
            SlowDown();
        }
        else if ((TouchController.touchInput.y < 0) && (-this.movableRangeY < this.transform.position.y))
        {
            spaceShipRB.velocity = new Vector2(spaceShipRB.velocity.x, -this.currentSpeed); // ���Ɉړ�
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

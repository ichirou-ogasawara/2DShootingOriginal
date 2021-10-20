using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : SpaceShip // SpaceShip�N���X���p��
{
    new float hp = 10;
    new float atk = 1;

    public Rigidbody2D rb; //rigidbody2d�R���|�[�l���g���i�[����ϐ�
    [SerializeField]private float moveSpeed = 7.0f; // �ړ����x
    public float movableRangeX = 2.5f; // ���̈ړ��\�͈�
    public float movableRangeY = 4.5f; // �c�̈ړ��\�͈�

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // rigidbody2d�R���|�[�l���g���擾
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.rb.velocity = new Vector2(0, 0);

        if ((TouchController.touchInput.x > 0) && (this.transform.position.x < this.movableRangeX))
        {
            this.rb.velocity = new Vector2(this.moveSpeed, rb.velocity.y); // �E�Ɉړ�
        }
        else if ((TouchController.touchInput.x < 0) && (-this.movableRangeX < this.transform.position.x))
        {
            this.rb.velocity = new Vector2(-this.moveSpeed, rb.velocity.y); // ���Ɉړ�
        }

        if ((TouchController.touchInput.y > 0) && (this.transform.position.y < this.movableRangeY))
        {
            this.rb.velocity = new Vector2(rb.velocity.x, this.moveSpeed); // ��Ɉړ�
        }
        else if ((TouchController.touchInput.y < 0) && (-this.movableRangeY < this.transform.position.y))
        {
            this.rb.velocity = new Vector2(rb.velocity.x, -this.moveSpeed); // ���Ɉړ�
        }
    }
}

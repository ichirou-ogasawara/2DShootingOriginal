using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : SpaceShip // SpaceShipクラスを継承
{
    public Rigidbody2D rb; //rigidbody2dコンポーネントを格納する変数
    [SerializeField]private float moveSpeed = 3.0f; // 移動速度
    private float movableRangeX = 2.5f; // 横の移動可能範囲
    private float movableRangeY = 4.5f; // 縦の移動可能範囲

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // rigidbody2dコンポーネントを取得
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.rb.velocity = new Vector2(0, 0);

        if ((TouchController.touchInput.x > 0) && (this.transform.position.x < this.movableRangeX))
        {
            this.rb.velocity = new Vector2(this.moveSpeed, 0); // 右に移動
        }
        else if ((TouchController.touchInput.x < 0) && (-this.movableRangeX < this.transform.position.x))
        {
            this.rb.velocity = new Vector2(-this.moveSpeed, 0); // 左に移動
        }

        else if ((TouchController.touchInput.y > 0) && (this.transform.position.y < this.movableRangeY))
        {
            this.rb.velocity = new Vector2(0, this.moveSpeed); // 上に移動
        }
        else if ((TouchController.touchInput.y < 0) && (-this.movableRangeY < this.transform.position.y))
        {
            this.rb.velocity = new Vector2(0, -this.moveSpeed); // 下に移動
        }
    }
}

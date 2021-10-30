using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : SpaceShip // SpaceShipクラスを継承
{
    [SerializeField] float buffDuration = 10f;
    float delta1 = 0;
    float delta2 = 0;

    [SerializeField] GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        spaceShipRB = GetComponent<Rigidbody2D>(); // rigidbody2dコンポーネントを取得
        ResetHp();
        currentSpeed = moveSpeed;
    }

    void Update()
    {
        if (isGetShipBuff == true)
        {
            delta1 += Time.deltaTime;
            if(delta1 > buffDuration)
            {
                ResetBuffShip();
                delta1 = 0;
            }
        }

        if (isGetBulletBuff == true)
        {
            delta2 += Time.deltaTime;
            if(delta2 > buffDuration)
            {
                ResetBuffBullet();
                delta2 = 0;
            }
        }

        if (this.currentHp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        this.spaceShipRB.velocity = new Vector2(0,0);

        if ((TouchController.touchInput.x > 0) && (this.transform.position.x < this.movableRangeX))
        {
            spaceShipRB.velocity = new Vector2(this.currentSpeed, spaceShipRB.velocity.y); // 右に移動
        }
        else if ((TouchController.touchInput.x < 0) && (-this.movableRangeX < this.transform.position.x))
        {
            spaceShipRB.velocity = new Vector2(-this.currentSpeed, spaceShipRB.velocity.y); // 左に移動
        }

        if ((TouchController.touchInput.y > 0) && (this.transform.position.y < this.movableRangeY))
        {
            spaceShipRB.velocity = new Vector2(spaceShipRB.velocity.x, this.currentSpeed); // 上に移動
        }
        else if ((TouchController.touchInput.y < 0) && (-this.movableRangeY < this.transform.position.y))
        {
            spaceShipRB.velocity = new Vector2(spaceShipRB.velocity.x, -this.currentSpeed); // 下に移動
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
            
        }
    }

    public void BuffShip(float value, float coefficient)
    {
        if (isGetShipBuff == false)
        {
            bodyAtk += value;
            currentSpeed *= coefficient;
            GetComponent<ParticleSystem>().Play();
        }
        isGetShipBuff = true;
    }
    public void ResetBuffShip()
    {
        currentSpeed = moveSpeed;
        bodyAtk = 1;
        GetComponent<ParticleSystem>().Stop();
        isGetShipBuff = false;
    }

    public void BuffBullet(float value, float coefficient)
    {
        if (isGetBulletBuff == false)
        {
            PlayerBullet.addAtk = value;
            PlayerBullet.addSpeed = coefficient;
            bulletPrefab.gameObject.GetComponent<ParticleSystem>().Play();
        }
        isGetBulletBuff = true;
    }

    public void ResetBuffBullet()
    {
        PlayerBullet.addAtk = 0;
        PlayerBullet.addSpeed = 1f;
        bulletPrefab.gameObject.GetComponent<ParticleSystem>().Stop();
        isGetBulletBuff = false;
    }
}

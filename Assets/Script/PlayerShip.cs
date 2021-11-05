using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShip : SpaceShip // SpaceShipクラスを継承
{
    [SerializeField] float buffDuration = 8.0f;
    float delta1 = 0.0f;
    float delta2 = 0.0f;

    [SerializeField] Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        spaceShipRB = GetComponent<Rigidbody2D>();
        ResetHp();
        slider.value = 1;
        currentSpeed = moveSpeed;
    }

    void Update()
    {
        if (isGetDamage)
        {
            slider.value = (float)currentHp / (float)maxHp;
        }

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
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            GetComponent<SoundController>().SE3();
            Destroy(this.gameObject);
            GameObject.Find("UICanvas").GetComponent<UIController>().GameOver();
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
            if (collision.gameObject.tag == "Boss")
            {
                this.bodyAtk = 0;
            }
            collision.gameObject.GetComponent<SpaceShip>().Hit(this.bodyAtk);
        }

        if (collision.gameObject.layer == LayerMask.NameToLayer("Item"))
        {
            delta1 = 0;
            delta2 = 0;
            GetComponent<SoundController>().SE2();
        }
        else if (!isGetShipBuff)
        {
            GetComponent<SoundController>().SE1();
        }
    }

    public void BuffShip(float value, float coefficient)
    {
        if (isGetShipBuff == false)
        {
            bodyAtk += value;
            currentSpeed *= coefficient;
            this.gameObject.GetComponent<ParticleSystem>().Play();
        }
        isGetShipBuff = true;
    }
    public void ResetBuffShip()
    {
        currentSpeed = moveSpeed;
        bodyAtk = 1;
        this.gameObject.GetComponent<ParticleSystem>().Stop();
        isGetShipBuff = false;
    }

    public void BuffBullet(float value, float coefficient)
    {
        if (isGetBulletBuff == false)
        {
            PlayerBullet.addAtk = value;
            PlayerBullet.addSpeed = coefficient;
        }
        isGetBulletBuff = true;
    }

    public void ResetBuffBullet()
    {
        PlayerBullet.addAtk = 0;
        PlayerBullet.addSpeed = 1f;
        isGetBulletBuff = false;
    }

    public void RestoreHp(float value)
    {
        currentHp += value;
        if (currentHp > maxHp)
        {
            currentHp = maxHp;
        }
        isGetDamage = true; // Hpゲージの表示に反映させるため
    }
}

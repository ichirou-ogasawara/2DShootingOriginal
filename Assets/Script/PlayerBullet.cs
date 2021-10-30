using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : Bullet // Bullet�N���X���p��
{
    Rigidbody2D bulletRB;

    public static float addAtk = 0;

    [SerializeField] float bulletSpeed;
    public static float addSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();      
    }

    private void Update()
    {
        // �e�o�t���̃p�[�e�B�N���������ōĐ�
        gameObject.GetComponent<ParticleSystem>().Play();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        bulletRB.velocity = new Vector2(0, 1) * bulletSpeed * addSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            collision.gameObject.GetComponent<SpaceShip>().Hit(bulletAtk + addAtk);       
        }

        PlayerBulletGenerator.instance.playerBulletPool.ReturnObj(gameObject);
    }
}

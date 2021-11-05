using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : Bullet // Bulletクラスを継承
{
    Rigidbody2D bulletRB;
    [SerializeField] ParticleSystem bulletParticle;

    public static float addAtk = 0.0f;

    [SerializeField] float bulletSpeed;
    public static float addSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
        bulletParticle = GetComponent<ParticleSystem>();
    }

    private void Update()
    {

    }
    // Update is called once per frame
    void FixedUpdate() 
    {
        bulletRB.velocity = new Vector2(0, 1) * bulletSpeed * addSpeed; 
        if (addSpeed > 1.0f)
        {
            bulletParticle.Play(); // Update関数内で使うと何故か不安定に
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            collision.gameObject.GetComponent<SpaceShip>().Hit(bulletAtk + addAtk);       
        }
    }
}

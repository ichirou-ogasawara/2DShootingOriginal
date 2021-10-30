using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInactivator : MonoBehaviour
{
    [SerializeField] protected float deadLineX = 9f;
    [SerializeField] protected float deadLineTop = 6f;
    [SerializeField] protected float deadLineUnder = -5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void DestroyBullet()
    {
        if (gameObject.layer == LayerMask.NameToLayer("PlayerBullet"))
        {
            PlayerBulletGenerator.instance.playerBulletPool.ReturnObj(gameObject);
        }
        else if (gameObject.layer == LayerMask.NameToLayer("EnemyBullet"))
        {
            EnemyBulletGenerator.instance.enemyBulletPool.ReturnObj(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -this.deadLineX || this.deadLineX < transform.position.x ||
            transform.position.y < this.deadLineUnder || this.deadLineTop < transform.position.y)
            
        {
            DestroyBullet();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Destroy(this.gameObject);
        DestroyBullet();
    }
}

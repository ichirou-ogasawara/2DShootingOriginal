using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInactivator : MonoBehaviour
{
    private float deadLineX = 3f;
    private float deadLineY = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void DestroyBullet()
    {
        BulletGenerator.instance.bulletPool.ReturnObj(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -this.deadLineX || this.deadLineX < transform.position.x ||
            transform.position.y < -this.deadLineY || this.deadLineY < transform.position.y)
            
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public Rigidbody2D bullet;

    public float moveSpeed = 7.0f;

    // Start is called before the first frame update
    void Start()
    {
        bullet = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bullet.velocity = new Vector2(0, 1) * moveSpeed;
    }
}

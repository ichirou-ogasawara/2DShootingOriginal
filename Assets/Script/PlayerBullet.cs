using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public Rigidbody2D bullet;

    [SerializeField] private float bulletSpeed = 7.0f;

    // Start is called before the first frame update
    void Start()
    {
        bullet = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bullet.velocity = new Vector2(0, 1) * bulletSpeed;
    }
}

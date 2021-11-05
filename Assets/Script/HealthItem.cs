using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : Item
{
    [SerializeField] private float recoveryAmount = 3.0f;
    void Start()
    {
        itemRB = GetComponent<Rigidbody2D>();
        Destroy(gameObject, deleteTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        itemRB.velocity = new Vector2(0, 1f) * -1 * moveSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            collision.gameObject.GetComponent<PlayerShip>().RestoreHp(this.recoveryAmount);
            Destroy(gameObject);
        }
    }
}

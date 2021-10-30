using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffShipItem : Item
{
    // Start is called before the first frame update
    void Start()
    {
        itemRB = GetComponent<Rigidbody2D>();
        Destroy(gameObject, deleteTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            collision.gameObject.GetComponent<PlayerShip>().BuffShip(this.atkIncreaseValue, this.SpeedUpCoefficient);
            Destroy(gameObject);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] PlayerShip playerShip;
    [SerializeField] PlayerBullet playerBullet;

    Rigidbody2D rb;

    protected float atkUpCoefficient = 2f;
    protected float maxSpeedUpCoefficient = 1.5f;
    protected float effectTime = 8f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "AttackModify")
        {
            playerBullet.Atk *= atkUpCoefficient;
        }
        else if (gameObject.tag == "MoveSpeedModify")
        {
            playerShip.MaxSpeed *= maxSpeedUpCoefficient;
        }
    }

    public void ItemEffect()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    protected Rigidbody2D itemRB;

    [SerializeField] protected float atkIncreaseValue = 1f;
    [SerializeField] protected float SpeedUpCoefficient = 1.5f;

    [SerializeField] protected float deleteTime = 10;
    [SerializeField] protected float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }

    public void ItemEffect()
    {

    }
}

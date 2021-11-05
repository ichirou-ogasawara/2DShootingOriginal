using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRed : Enemy
{
    GameObject itemGenerator;

    float delta;
    [SerializeField] float dropSpan = 8f;

    protected float stopPos = 2.8f;
    bool isMovingSide = false;

    [SerializeField] float timeScore = 0;
    [SerializeField] float maxTime = 30f; // maxTime秒以上時間をかけるとスコアボーナス無し 

    // Start is called before the first frame update
    void Start()
    {
        ResetHp();
        moveSidePos = new Vector2(0, stopPos);
        itemGenerator =  GameObject.Find("ItemGenerator");
        movableRangeX += 5f;
        movableRangeY -= 2f;
        spaceShipRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (BackgroundController.isComingBoss)
        {
            if (transform.position.y <= stopPos)
            {
                isMovingSide = true;
            }

            if (!isMovingSide)
            {
                transform.Translate(0, moveSpeed * Time.deltaTime, 0);
            }
            else
            {
                MoveSide();
            }

            this.timeScore += Time.deltaTime; // Bossが現れてからの時間を計測
        }

        this.delta += Time.deltaTime;

        if (this.delta > this.dropSpan)
        {
            this.delta = 0;
            if (currentHp < maxHp)
            {
                itemGenerator.GetComponent<ItemDroper>().DropItem(this.gameObject, 10);
            }
            else if (currentHp <= 40)
            {
                itemGenerator.GetComponent<ItemDroper>().DropItem(this.gameObject, 7);
            }
            else if (currentHp <= 20)
            {
                itemGenerator.GetComponent<ItemDroper>().DropItem(this.gameObject, 4);
            }
        }
        if (currentHp <= 0)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            if (timeScore < maxTime)
            {
                UIController.score += (maxTime - timeScore);
            }
            UIController.score += addScore;
            GameObject.Find("UICanvas").GetComponent<UIController>().GameClear();
            Destroy(gameObject);
        }
    }    
    

    private void FixedUpdate()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            collision.gameObject.GetComponent<SpaceShip>().Hit(bodyAtk);
        }
    }
}

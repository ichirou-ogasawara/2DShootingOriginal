using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletGenerator : MonoBehaviour
{
    public static PlayerBulletGenerator instance;

    public Transform bulletSpawnPos;

    public ObjectPool playerBulletPool;

    [SerializeField] private float rateOfFire = 0.5f; //連射速度
    public float currentTime = 0.0f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        bulletSpawnPos = gameObject.transform;
    }
    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= rateOfFire)
        {

            // オブジェクトプールのメソッドで弾をアクティブにする
            playerBulletPool.SpawnObj(bulletSpawnPos.position);
            currentTime = 0;
        }        
    }

    public void Shoot()
    {

    }

}

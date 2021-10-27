using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletGenerator : MonoBehaviour
{
    public static EnemyBulletGenerator instance;

    public Transform bulletSpawnPos;

    public ObjectPool enemyBulletPool;

    [SerializeField] private float nextFire; //�A�ˑ��x
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
        enemyBulletPool = GameObject.Find("ObjectPool(RedBullet)").GetComponent<ObjectPool>();
        bulletSpawnPos = gameObject.transform;
    }
    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > nextFire)
        {
            // �I�u�W�F�N�g�v�[���̃��\�b�h�Œe���A�N�e�B�u�ɂ���
            enemyBulletPool.SpawnObj(bulletSpawnPos.position);
            currentTime = 0;
        }
    }

    public void Shoot()
    {

    }

}
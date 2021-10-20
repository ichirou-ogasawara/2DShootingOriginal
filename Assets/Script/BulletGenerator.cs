using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public Transform bulletSpawn;
    public GameObject bullet;

    [SerializeField] private float nextFire = 0.5f;
    public float currentTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        bulletSpawn = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    public void Shoot()
    {
        currentTime += Time.deltaTime;

        if (currentTime > nextFire)
        {
            nextFire += currentTime;

            GameObject bulletInstance = Instantiate(bullet, bulletSpawn.position, Quaternion.identity);
            if (gameObject.layer == LayerMask.NameToLayer("Player"))
            {
                bulletInstance.layer = LayerMask.NameToLayer("PlayerBullet");
            }
            else
            {
                bulletInstance.layer = LayerMask.NameToLayer("EnemyBullet");
            }

            nextFire -= currentTime;
            currentTime = 0.0f;
        }
    }
}

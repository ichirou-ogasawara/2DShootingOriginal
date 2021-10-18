using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform bulletSpawn;
    public GameObject bullet;

    public float nextFire = 0.5f;
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

            Instantiate(bullet, bulletSpawn.position, Quaternion.identity);

            nextFire -= currentTime;
            currentTime = 0.0f;
        }
    }
}

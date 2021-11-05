using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonGenerator : MonoBehaviour
{
    [SerializeField] SpaceShip bossShip;
    [SerializeField] Transform canonSpawn;
    public GameObject canonPrefab;

    [SerializeField] private float rateOfFire = 4.0f; //˜AŽË‘¬“x
    public float currentTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        canonSpawn = gameObject.transform;       
    }
    // Update is called once per frame
    void Update()
    {
        if (BackgroundController.isComingBoss)
        {
            currentTime += Time.deltaTime;

            if (currentTime >= rateOfFire)
            {
                Instantiate(canonPrefab, canonSpawn.position, Quaternion.identity);
                currentTime = 0;
            }

            if (bossShip.CurrentHp < 20)
            {
                rateOfFire = 2f;
            }
        }
    }
}

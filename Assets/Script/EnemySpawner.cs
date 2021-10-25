using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner instance;

    public GameObject enemyPrefab;

    [SerializeField] private float span; // ¶¬ŠÔŠu
    [SerializeField] private float offset;

    private float delta = 0; // ŽžŠÔŒv‘ª—p‚Ì•Ï”
    private Vector2 spawnPos;

    public ObjectPool enemyRedPool;

    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0;
            spawnPos = new Vector2(Random.Range(-2.5f, 2.5f), 5f);
            enemyRedPool.SpawnObj(spawnPos);
        }
    }
}

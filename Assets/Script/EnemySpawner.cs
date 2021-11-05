using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner instance;

    public GameObject enemyFormationPrefab;

    [SerializeField] private float span; // ¶¬ŽžŠÔŠÔŠu
    [SerializeField] private float spaceX = 1f; // 2‹@¶¬‚µ‚½‚Æ‚«‚Ì‹——£ŠÔŠu
    [SerializeField] private float offsetTime;

    private float rangeX = 8.5f;

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

        if (this.delta > this.span && !BackgroundController.isComingBoss && !UIController.isGameEnd)
        {
            this.delta = 0;
            int n = Random.Range(1, 11);
            if (1 <= n && n <= 6)
            {
                spawnPos = new Vector2(Random.Range(-rangeX, rangeX), 5f);
                enemyRedPool.SpawnObj(spawnPos);
            }
            else if (6 <= n && n <= 9)
            {
                float pos = Random.Range(-rangeX, rangeX-0.5f);
                for (int i = 0; i < 2; i++)
                {
                    spawnPos = new Vector2(pos + this.spaceX * i, 5f);
                    enemyRedPool.SpawnObj(spawnPos);
                }
            }
            else if (10 == n)
            {
                GameObject go = Instantiate(enemyFormationPrefab);
                go.transform.position = new Vector2(Random.Range(-rangeX, rangeX), 5f);
            }

            this.span = this.offsetTime * n;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject objectToPool; // poolに入れるプレハブ
    public List<GameObject> pool = new List<GameObject>(); 
    public int startAmount; // 最初に生成する量

    // Start is called before the first frame update
    void Start()
    {
        // 最初にオブジェクトプールを生成して、非表示にしておく
        for (int i = 0; i < startAmount; i++)
        {
            pool.Add(Instantiate(objectToPool, transform));
            pool[i].SetActive(false);
        }
    }

    void Generate()
    {
        GameObject instance = Instantiate(objectToPool, transform);
        pool.Add(instance);
        instance.SetActive(false);
    }

    public GameObject SpawnObj(Vector2 position) // 位置を指定してプールのオブジェクトをアクティブにするメソッド
    {
        if (pool.Count <= 0) // プールにオブジェクトが無ければ生成
        {
            Generate();
            Debug.LogWarning(objectToPool.name + "が足りません");
        }

        GameObject obj = pool[0];
        pool.RemoveAt(0); // プールの0番目の要素を削除

        obj.SetActive(true); // アクティブにする
        obj.transform.position = position;

        return obj;
    }

    public void ReturnObj(GameObject objectToReturn) // 使わなくなったオブジェクトをプールに戻して非アクティブにするメソッド
    {
        pool.Add(objectToReturn);
        objectToReturn.SetActive(false);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

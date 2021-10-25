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
            pool.Add(Instantiate(objectToPool));
            pool[i].SetActive(false);
            pool[i].transform.parent = transform;
        }
    }

    public GameObject SpawnObj(Vector2 position) // 位置を指定してプールのオブジェクトをアクティブにするメソッド
    {
        GameObject obj;

        if (pool.Count > 0) // プールにオブジェクトがあれば削除
        {
            obj = pool[0];
            pool.RemoveAt(0);
        }
        else                // 無ければ生成
        {
            obj = Instantiate(objectToPool);
            obj.transform.parent = transform;
        }

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

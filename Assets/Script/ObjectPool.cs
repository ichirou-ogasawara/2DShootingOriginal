using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject objectToPool; // pool�ɓ����v���n�u
    public List<GameObject> pool = new List<GameObject>(); 
    public int startAmount; // �ŏ��ɐ��������

    // Start is called before the first frame update
    void Start()
    {
        // �ŏ��ɃI�u�W�F�N�g�v�[���𐶐����āA��\���ɂ��Ă���
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

    public GameObject SpawnObj(Vector2 position) // �ʒu���w�肵�ăv�[���̃I�u�W�F�N�g���A�N�e�B�u�ɂ��郁�\�b�h
    {
        if (pool.Count <= 0) // �v�[���ɃI�u�W�F�N�g��������ΐ���
        {
            Generate();
            Debug.LogWarning(objectToPool.name + "������܂���");
        }

        GameObject obj = pool[0];
        pool.RemoveAt(0); // �v�[����0�Ԗڂ̗v�f���폜

        obj.SetActive(true); // �A�N�e�B�u�ɂ���
        obj.transform.position = position;

        return obj;
    }

    public void ReturnObj(GameObject objectToReturn) // �g��Ȃ��Ȃ����I�u�W�F�N�g���v�[���ɖ߂��Ĕ�A�N�e�B�u�ɂ��郁�\�b�h
    {
        pool.Add(objectToReturn);
        objectToReturn.SetActive(false);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

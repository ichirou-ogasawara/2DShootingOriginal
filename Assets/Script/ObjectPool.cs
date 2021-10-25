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
            pool.Add(Instantiate(objectToPool));
            pool[i].SetActive(false);
            pool[i].transform.parent = transform;
        }
    }

    public GameObject SpawnObj(Vector2 position) // �ʒu���w�肵�ăv�[���̃I�u�W�F�N�g���A�N�e�B�u�ɂ��郁�\�b�h
    {
        GameObject obj;

        if (pool.Count > 0) // �v�[���ɃI�u�W�F�N�g������΍폜
        {
            obj = pool[0];
            pool.RemoveAt(0);
        }
        else                // ������ΐ���
        {
            obj = Instantiate(objectToPool);
            obj.transform.parent = transform;
        }

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

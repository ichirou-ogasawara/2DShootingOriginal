using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour // Player�̒e��Enemy�̒e�ւƌp��������
{
    protected Rigidbody2D bulletRB;
    [SerializeField] protected float atk; // �U����
    [SerializeField] protected float bulletSpeed; // �e�̑��x

    public float Atk
    {
        get
        {
            return atk;
        }
        protected set
        {
            value = atk;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

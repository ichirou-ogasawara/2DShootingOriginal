using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour // Player�̒e��Enemy�̒e�ւƌp��������
{
    [SerializeField] protected float bulletAtk;

    public float BulletAtk
    {
        get
        {
            return bulletAtk;
        }
        protected set
        {
            value = bulletAtk;
        }
    }
}

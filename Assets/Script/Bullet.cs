using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour // Player‚Ì’e‚ÆEnemy‚Ì’e‚Ö‚ÆŒp³‚³‚¹‚é
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

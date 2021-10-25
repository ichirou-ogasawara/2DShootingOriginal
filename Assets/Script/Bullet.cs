using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour // Player‚Ì’e‚ÆEnemy‚Ì’e‚Ö‚ÆŒp³‚³‚¹‚é
{
    protected Rigidbody2D bulletRB;
    [SerializeField] protected float atk; // UŒ‚—Í
    [SerializeField] protected float bulletSpeed; // ’e‚Ì‘¬“x

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

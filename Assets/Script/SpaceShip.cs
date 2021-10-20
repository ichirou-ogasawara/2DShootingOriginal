using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpaceShip : MonoBehaviour
{
    protected float hp;
    protected float atk;

    public float Hp // hp�v���p�e�B�̒�`
    {
        get
        {
            return hp;
        }
        protected set
        {
            hp = value;
        }
    }
    public float Atk // atk�v���p�e�B�̒�`
    {
        get
        {
            return atk;
        }
        protected set
        {
            atk = value;
        }
    }
    
    public void Hit(SpaceShip target) // �U�����\�b�h
    {
        target.hp -= atk;
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

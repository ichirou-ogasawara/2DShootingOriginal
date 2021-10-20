using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpaceShip : MonoBehaviour
{
    protected float hp;
    protected float atk;

    public float Hp // hpプロパティの定義
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
    public float Atk // atkプロパティの定義
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
    
    public void Hit(SpaceShip target) // 攻撃メソッド
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

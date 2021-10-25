using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpaceShip : MonoBehaviour // この戦闘機クラスを親クラスとし、自機、敵機へと継承させる。
{
    protected Rigidbody2D spaceShipRB;

    [SerializeField] protected float hp; // 体力
    [SerializeField] protected float moveSpeed; // 機体の移動速度
    [SerializeField] protected float bodyAtk; // 他の機体にぶつかったときの攻撃力

    protected float movableRangeX = 2.5f; // 横の移動可能範囲
    protected float movableRangeY = 4.5f; // 縦の移動可能範囲

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
    public float Movespeed // moveSpeedプロパティの定義
    {
        get
        {
            return moveSpeed;
        }
        protected set
        {
            moveSpeed = value;
        }
    }
    
    public void Hit(float damage) // 攻撃を受けるとhpを減らすメソッド
    {
        hp -= damage;
    }

}

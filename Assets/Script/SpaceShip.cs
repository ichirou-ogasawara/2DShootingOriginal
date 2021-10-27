using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpaceShip : MonoBehaviour // この戦闘機クラスを親クラスとし、自機、敵機へと継承させる。
{
    protected Rigidbody2D spaceShipRB;

    [SerializeField] protected float maxHp; // 最大体力
    protected float currentHp; // 現在の体力
    [SerializeField] protected float maxSpeed; // 機体の移動速度
    protected float currentSpeed;
    protected float coefficient = 0.99f;
    [SerializeField] protected float bodyAtk; // 他の機体にぶつかったときの攻撃力

    protected float movableRangeX = 8.5f; // 横の移動可能範囲
    protected float movableRangeY = 4.5f; // 縦の移動可能範囲

    public float MaxHp // maxHpプロパティの定義
    {
        get
        {
            return maxHp;
        }
        protected set
        {
            maxHp = value;
        }
    }
    public float CurrentHp // curerntHpプロパティの定義
    {
        get
        {
            return currentHp;
        }
        protected set
        {
            currentHp = value;
        }
    }
    public float MaxSpeed // maxSpeedプロパティの定義
    {
        get
        {
            return maxSpeed;
        }
        set
        {
            maxSpeed = value;
        }
    }
    
    public void Hit(float damage) // 攻撃を受けるとhpを減らすメソッド
    {
        currentHp -= damage;
    }

    protected void ResetHp() // 復活した機体のパラメータをリセット
    {
        currentHp = maxHp;
    }

    protected void SlowDown()
    {
        float countDown = 0;
        countDown += Time.deltaTime;
        if (countDown >= 1 && currentSpeed > 0)
        {
            currentSpeed *= this.coefficient;
        }
        countDown = 0;
        currentSpeed = maxSpeed;
    }
}

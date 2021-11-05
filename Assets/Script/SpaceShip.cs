using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpaceShip : MonoBehaviour // この戦闘機クラスを親クラスとし、自機、敵機へと継承させる。
{
    protected Rigidbody2D spaceShipRB;
    [SerializeField] protected GameObject explosionPrefab;

    [SerializeField] protected float maxHp; // 最大体力
    protected float currentHp; // 現在の体力
    [SerializeField] protected float moveSpeed; // 機体の移動速度
    protected float currentSpeed; // バフ時の計算用
    [SerializeField] protected float bodyAtk; // 他の機体にぶつかったときの攻撃力

    protected bool isGetShipBuff = false;
    protected bool isGetBulletBuff = false;

    protected bool isGetDamage = false;

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
    public float MoveSpeed // maxSpeedプロパティの定義
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
    
    public void Hit(float damage) // 攻撃を受けるとhpを減らすメソッド // バフ時は無敵
    {
        if (!isGetShipBuff && !UIController.isGameEnd)
        {
            currentHp -= damage;
            isGetDamage = true;
        }

    }

    protected void ResetHp() // 復活した機体のパラメータをリセット
    {
        currentHp = maxHp;
    }
}

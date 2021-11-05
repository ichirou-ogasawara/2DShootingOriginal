using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpaceShip : MonoBehaviour // ���̐퓬�@�N���X��e�N���X�Ƃ��A���@�A�G�@�ւƌp��������B
{
    protected Rigidbody2D spaceShipRB;
    [SerializeField] protected GameObject explosionPrefab;

    [SerializeField] protected float maxHp; // �ő�̗�
    protected float currentHp; // ���݂̗̑�
    [SerializeField] protected float moveSpeed; // �@�̂̈ړ����x
    protected float currentSpeed; // �o�t���̌v�Z�p
    [SerializeField] protected float bodyAtk; // ���̋@�̂ɂԂ������Ƃ��̍U����

    protected bool isGetShipBuff = false;
    protected bool isGetBulletBuff = false;

    protected bool isGetDamage = false;

    protected float movableRangeX = 8.5f; // ���̈ړ��\�͈�
    protected float movableRangeY = 4.5f; // �c�̈ړ��\�͈�

    public float MaxHp // maxHp�v���p�e�B�̒�`
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
    public float CurrentHp // curerntHp�v���p�e�B�̒�`
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
    public float MoveSpeed // maxSpeed�v���p�e�B�̒�`
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
    
    public void Hit(float damage) // �U�����󂯂��hp�����炷���\�b�h // �o�t���͖��G
    {
        if (!isGetShipBuff && !UIController.isGameEnd)
        {
            currentHp -= damage;
            isGetDamage = true;
        }

    }

    protected void ResetHp() // ���������@�̂̃p�����[�^�����Z�b�g
    {
        currentHp = maxHp;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpaceShip : MonoBehaviour // ���̐퓬�@�N���X��e�N���X�Ƃ��A���@�A�G�@�ւƌp��������B
{
    protected Rigidbody2D spaceShipRB;

    [SerializeField] protected float maxHp; // �ő�̗�
    protected float currentHp; // ���݂̗̑�
    [SerializeField] protected float maxSpeed; // �@�̂̈ړ����x
    protected float currentSpeed;
    protected float coefficient = 0.99f;
    [SerializeField] protected float bodyAtk; // ���̋@�̂ɂԂ������Ƃ��̍U����

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
    public float MaxSpeed // maxSpeed�v���p�e�B�̒�`
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
    
    public void Hit(float damage) // �U�����󂯂��hp�����炷���\�b�h
    {
        currentHp -= damage;
    }

    protected void ResetHp() // ���������@�̂̃p�����[�^�����Z�b�g
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

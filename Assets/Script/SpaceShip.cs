using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpaceShip : MonoBehaviour // ���̐퓬�@�N���X��e�N���X�Ƃ��A���@�A�G�@�ւƌp��������B
{
    protected Rigidbody2D spaceShipRB;

    [SerializeField] protected float hp; // �̗�
    [SerializeField] protected float moveSpeed; // �@�̂̈ړ����x
    [SerializeField] protected float bodyAtk; // ���̋@�̂ɂԂ������Ƃ��̍U����

    protected float movableRangeX = 2.5f; // ���̈ړ��\�͈�
    protected float movableRangeY = 4.5f; // �c�̈ړ��\�͈�

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
    public float Movespeed // moveSpeed�v���p�e�B�̒�`
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
    
    public void Hit(float damage) // �U�����󂯂��hp�����炷���\�b�h
    {
        hp -= damage;
    }

}

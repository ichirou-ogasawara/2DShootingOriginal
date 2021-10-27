using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchController : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    Vector2 startPosition;
    public static Vector2 touchInput;

    void Start()
    {
        
    }

    public void OnBeginDrag(PointerEventData data)
    {
        startPosition = data.position; // �h���b�O�J�n�ʒu�̃f�[�^����
    }

    public void OnDrag(PointerEventData data)
    {
        // �h���b�O�����Ԃ�̃f�[�^�𐳋K�����đ��
        touchInput = (data.position - startPosition); 
    }
}

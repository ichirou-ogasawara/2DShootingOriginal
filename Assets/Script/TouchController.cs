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
        startPosition = data.position; // ドラッグ開始位置のデータを代入
    }

    public void OnDrag(PointerEventData data)
    {
        // ドラッグしたぶんのデータを正規化して代入
        touchInput = (data.position - startPosition); 
    }
}

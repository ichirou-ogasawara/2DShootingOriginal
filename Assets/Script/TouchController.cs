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
        startPosition = data.position; // タッチした位置をドラッグ開始位置とする
    }

    public void OnDrag(PointerEventData data)
    {
        touchInput = (data.position - startPosition).normalized;
    }
}

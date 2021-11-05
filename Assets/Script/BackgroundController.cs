using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = -0.5f;
    [SerializeField] private float deadLine = -15f;

    public static bool isComingBoss = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= this.deadLine) // 停止位置に来たらボス出動フラグをtrueに
        {
            isComingBoss = true;
        }

        // ボス出動状態でなく,且つゲームオーバーでもない限り、背景をスクロール(ボス出動フラグかゲームオーバーになると止まる)
        if (!isComingBoss && !UIController.isGameEnd)
        {
            transform.Translate(0, this.scrollSpeed * Time.deltaTime, 0);
        }
    }
}

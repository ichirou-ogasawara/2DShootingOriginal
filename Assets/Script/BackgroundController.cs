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
        if (transform.position.y <= this.deadLine) // ��~�ʒu�ɗ�����{�X�o���t���O��true��
        {
            isComingBoss = true;
        }

        // �{�X�o����ԂłȂ�,���Q�[���I�[�o�[�ł��Ȃ�����A�w�i���X�N���[��(�{�X�o���t���O���Q�[���I�[�o�[�ɂȂ�Ǝ~�܂�)
        if (!isComingBoss && !UIController.isGameEnd)
        {
            transform.Translate(0, this.scrollSpeed * Time.deltaTime, 0);
        }
    }
}

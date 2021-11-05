using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] protected AudioSource audioSource;//AudioSource�^�̕ϐ�audioSource��錾 �g�p����AudioSource�R���|�[�l���g���A�^�b�`�K�v

    [SerializeField] protected AudioClip audioClip1;//AudioClip�^�̕ϐ�audioClip1��錾 �g�p����AudioClip���A�^�b�`�K�v
    [SerializeField] protected AudioClip audioClip2;//AudioClip�^�̕ϐ�audioClip2��錾 �g�p����AudioClip���A�^�b�`�K�v 
    [SerializeField] protected AudioClip audioClip3;//AudioClip�^�̕ϐ�audioClip3��錾 �g�p����AudioClip���A�^�b�`�K�v 

    protected bool isChangeBGM = false;

    //����̊֐�1
    public void SE1()
    {
        audioSource.PlayOneShot(audioClip1);
    }

    //����̊֐�2
    public void SE2()
    {
        audioSource.PlayOneShot(audioClip2);
    }

    //����̊֐�3
    public void SE3()
    {
        audioSource.PlayOneShot(audioClip3);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}

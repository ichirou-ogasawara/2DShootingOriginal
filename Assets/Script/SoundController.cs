using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] protected AudioSource audioSource;//AudioSource型の変数audioSourceを宣言 使用するAudioSourceコンポーネントをアタッチ必要

    [SerializeField] protected AudioClip audioClip1;//AudioClip型の変数audioClip1を宣言 使用するAudioClipをアタッチ必要
    [SerializeField] protected AudioClip audioClip2;//AudioClip型の変数audioClip2を宣言 使用するAudioClipをアタッチ必要 
    [SerializeField] protected AudioClip audioClip3;//AudioClip型の変数audioClip3を宣言 使用するAudioClipをアタッチ必要 

    protected bool isChangeBGM = false;

    //自作の関数1
    public void SE1()
    {
        audioSource.PlayOneShot(audioClip1);
    }

    //自作の関数2
    public void SE2()
    {
        audioSource.PlayOneShot(audioClip2);
    }

    //自作の関数3
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

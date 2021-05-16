using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource tirSrc;
    public AudioSource clickSrc;
    public AudioSource killSrc;
    public AudioSource dieSrc;
    public AudioSource degatsSrc;


    public AudioSource musicSrc;

    public AudioClip tirClp;
    public AudioClip clickClp;
    public AudioClip killClp;
    public AudioClip dieClp;
    public AudioClip degatsClp;


    public AudioClip musicClp;

    public static AudioManager audioInstance;


    private void Awake()
    {
        if(audioInstance != null && audioInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        audioInstance = this;
        DontDestroyOnLoad(this);
    }
}

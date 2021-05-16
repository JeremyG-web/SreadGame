using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mort : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.audioInstance.dieSrc.PlayOneShot(AudioManager.audioInstance.dieClp);
    }


}

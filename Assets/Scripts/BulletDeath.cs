using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDeath : MonoBehaviour
{
  
    Rigidbody rig;
    void Start()
    {
        rig = GetComponent<Rigidbody>();

    }
    private void OnTriggerEnter(Collider enemy)
    {
        Debug.Log("hello");

        switch (gameObject.tag)
        {

            case "redBullet":

                if (enemy.CompareTag("redEnemy"))
                {
                    Destroy(gameObject);
                }

                if (enemy.CompareTag("blueEnemy"))
                {
                    GameObject thePlayer = GameObject.Find("player");
                    RotationPlayer rotationPlayer = thePlayer.GetComponent<RotationPlayer>();
                    rotationPlayer.playerLife -= 1;
                    AudioManager.audioInstance.degatsSrc.PlayOneShot(AudioManager.audioInstance.degatsClp);

                    rotationPlayer.flash = false;
                    Debug.Log("AH");

                    Destroy(gameObject);
                }

                break;

            case "blueBullet":
                if (enemy.CompareTag("blueEnemy"))
                {
                    Destroy(gameObject);
                }
                if (enemy.CompareTag("redEnemy"))
                {
                    GameObject thePlayer = GameObject.Find("player");
                    RotationPlayer rotationPlayer = thePlayer.GetComponent<RotationPlayer>();
                    rotationPlayer.flash = false ;
                    rotationPlayer.playerLife -= 1;
                    AudioManager.audioInstance.degatsSrc.PlayOneShot(AudioManager.audioInstance.degatsClp);

                    Debug.Log("AH");

                    Destroy(gameObject);
                    //Debug.Log("TakeDamage");
                }
                break;

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

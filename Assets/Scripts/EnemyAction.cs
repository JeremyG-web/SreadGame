using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAction : MonoBehaviour
{
    public Transform target;
    [SerializeField] ParticleSystem collectParticle = null;
   // public GameObject player;
    public float speed = 4f;
    Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        
    }
    private void OnTriggerEnter(Collider boule)
    {


        switch(gameObject.tag)
        {
            

            case "redEnemy":
                
                if (boule.CompareTag("redBullet"))
                {
                    Destroy(gameObject);
                    AudioManager.audioInstance.killSrc.PlayOneShot(AudioManager.audioInstance.killClp);

                }
                if (boule.CompareTag("Player"))
                {
                    Destroy(gameObject);
                    AudioManager.audioInstance.killSrc.PlayOneShot(AudioManager.audioInstance.killClp);

                }

                break;

            case "blueEnemy":
                if (boule.CompareTag("blueBullet"))
                {

                    Destroy(gameObject);

                    AudioManager.audioInstance.killSrc.PlayOneShot(AudioManager.audioInstance.killClp);


                }
                if (boule.CompareTag("Player"))
                {
                    Destroy(gameObject);
                    AudioManager.audioInstance.killSrc.PlayOneShot(AudioManager.audioInstance.killClp);

                }

                break;

        }
       
       
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
        rig.MovePosition(pos);
        transform.LookAt(target);
        

    }
}

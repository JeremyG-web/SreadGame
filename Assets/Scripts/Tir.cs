using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tir : MonoBehaviour
{
    public GameObject Projectile; 
    public GameObject Projectile2;
    public RotationPlayer rotationPlayer;
    public int force = 10;
    public float lifeTime = 2f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
/*
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Boule= Instantiate(Projectile,transform.position, Quaternion.identity) as GameObject;
            Boule.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * force);
            Destroy(Boule, 2f);
        }
*/
        if (Input.GetMouseButtonDown(0) && rotationPlayer.playerLife > 0)
        {
            GameObject Boule= Instantiate(Projectile,transform.position, Quaternion.identity) as GameObject;
            Boule.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * force);
            AudioManager.audioInstance.tirSrc.PlayOneShot(AudioManager.audioInstance.tirClp);

            Destroy(Boule, lifeTime);
            
        }
        if (Input.GetMouseButtonDown(1) && rotationPlayer.playerLife > 0)
        {
            GameObject Boule= Instantiate(Projectile2,transform.position, Quaternion.identity) as GameObject;
            Boule.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * force);
            AudioManager.audioInstance.tirSrc.PlayOneShot(AudioManager.audioInstance.tirClp);

            Destroy(Boule, lifeTime);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemy1;

    public GameObject object1;

    public GameObject object2;

    private float posx;
    private float posz;
    public float nbEnemy; 
    public int enemyCount;

    private float posxobj1;
    private float poszobj1;
    private float posxobj2;
    private float poszobj2;

    private bool theenemy = true;

    private bool beingHandled = false;

    public float timeWait = 5f;

    public float targetTime = 0f;

    public float phaseSup = 10f;
    public int nPhase;

    public RotationPlayer rotationPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
       

        posxobj1 = object1.transform.position.x;
        poszobj1 = object1.transform.position.z;
        posxobj2 = object2.transform.position.x;
        poszobj2 = object2.transform.position.z;


    }

    // Update is called once per frame
    void Update()
    {
        
        targetTime += Time.deltaTime;
        if(!beingHandled && rotationPlayer.playerLife > 0 )
        {
            StartCoroutine(EnemyDrop());
        }
    }

    IEnumerator EnemyDrop()
    {
        if (targetTime >= phaseSup)
        {
            nbEnemy = (float)(nbEnemy * 1.5);

            phaseSup = (float)(phaseSup * 1.5);

            nPhase += 1;
        }
        beingHandled = true;
        while (enemyCount <= nbEnemy)
        {
            posx = Random.Range(posxobj2, posxobj1);
            posz = Random.Range(poszobj1, poszobj2);

            if (theenemy == true)
            {
                Instantiate(enemy, new Vector3(posx, 1, posz), Quaternion.identity);
                yield return new WaitForSeconds(0.1f);
                theenemy = false;
            }
            else
            {
                Instantiate(enemy1, new Vector3(posx, 1, posz), Quaternion.identity);
                yield return new WaitForSeconds(0.1f);
                theenemy = true;
                
            }
            enemyCount += 1;
            
        }

        if (enemyCount >= nbEnemy)
        {
            yield return new WaitForSeconds(timeWait);
            enemyCount =  0;
        }
        beingHandled = false;

    }
}

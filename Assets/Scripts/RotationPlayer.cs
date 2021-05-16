using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RotationPlayer : MonoBehaviour
{
    public GameObject panel;
    public GameObject paneltoclose;
    public GameManager gameManager;
    public int playerLife = 5; 
    public Camera cam;
    Vector3 pos;
    Ray mouseCoord;
    Rigidbody rig;
    [SerializeField] FlashImage _flashImage = null;
    public bool flash = true ;
    
    void Start()
    {
        
        rig = GetComponent<Rigidbody>();
    }
    void Update() {
    
        mouseCoord = cam.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(mouseCoord,out RaycastHit RaycastHit))
        {
            pos = RaycastHit.point;
            pos = new Vector3(pos.x , 0, pos.z );

        }
        transform.LookAt(new Vector3(pos.x,transform.position.y,pos.z ), new Vector3(10, 0,0));


        Debug.Log(pos.x + " _ " + pos.z);
        if (flash == false)
        {
            _flashImage.StartFlash(0.25f, 0.5f, Color.red);
            Debug.Log("aie");
            flash = true;
        }

        if (playerLife <= 0)
        {
            

            gameManager.showPanel(panel);
            gameManager.hidePanel(paneltoclose);

        }
    }
    private void OnTriggerEnter(Collider boule)
    {
        if (boule.CompareTag("redEnemy") || boule.CompareTag("blueEnemy"))
        {
            playerLife -= 1;
            AudioManager.audioInstance.degatsSrc.PlayOneShot(AudioManager.audioInstance.degatsClp);
            Debug.Log("trigger");
            flash = false;
        }



    }


}

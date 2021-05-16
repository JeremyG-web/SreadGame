using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Timer : MonoBehaviour
{
    public Text timerText;
    public Text lifeTexte;
    public Text phaseTexte;
    public Text phaseScore;
    public Text phaseSuperieur;

    private float startTime;
    private string minutes;
    private string seconds;


    private bool finnished = false;

    void Start()
    {
        startTime = Time.time;    
    }

    // Update is called once per frame
    void Update()
    {
        GameObject genEnemy = GameObject.Find("Spawner Enemy");
        GenerateEnemy generateEnemy = genEnemy.GetComponent<GenerateEnemy>();

        string phase = (generateEnemy.nPhase).ToString();
        string phaseSupe = (generateEnemy.phaseSup).ToString();

        GameObject thePlayer = GameObject.Find("player");
        RotationPlayer rotationPlayer = thePlayer.GetComponent<RotationPlayer>();

        string life = (rotationPlayer.playerLife).ToString();

        float t = Time.time - startTime;
        
        string minutes = ((int)t / 60).ToString();
        string seconds = ((int)t % 60).ToString();

        phaseSuperieur.text = "Next Phase : " + phaseSupe;
        phaseTexte.text = "Phase : " + phase;
        timerText.text = minutes + ":" + seconds;
        lifeTexte.text = "Life : " + life;


        if (rotationPlayer.playerLife <= 0)
        {

            Finnish();
            

        }
    }
    public void Finnish()
    {
        GameObject genEnemy = GameObject.Find("Spawner Enemy");
        GenerateEnemy generateEnemy = genEnemy.GetComponent<GenerateEnemy>();

        string phase = (generateEnemy.nPhase).ToString();

        GameObject thePlayer = GameObject.Find("player");
        RotationPlayer rotationPlayer = thePlayer.GetComponent<RotationPlayer>();

        finnished = true;
        timerText.color = Color.yellow;
        phaseScore.text = "Phase : " + phase;
    }

    
}

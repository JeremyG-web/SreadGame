using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public void showPanel(GameObject Panel)
    {
        
        Panel.SetActive(true);
    }
    public void hidePanel(GameObject Panel)
    {
        Panel.SetActive(false);
    }

    public void LoadScene(string scenename)
    {
        AudioManager.audioInstance.clickSrc.PlayOneShot(AudioManager.audioInstance.clickClp);

        SceneManager.LoadScene(scenename);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManage : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string name)
    {
        AudioManager.audioInstance.clickSrc.PlayOneShot(AudioManager.audioInstance.clickClp);

        SceneManager.LoadScene(name);
    }

    // Update is called once per frame
    public void doExitGame()
    {
        AudioManager.audioInstance.clickSrc.PlayOneShot(AudioManager.audioInstance.clickClp);

        Application.Quit();
        Debug.Log("Quit");

    }
}

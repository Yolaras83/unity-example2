using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public AudioSource PlayAS;
    public AudioSource SettingsAS;
    public AudioSource QuitAS;
    public void Play()
    {
        StartCoroutine(DelayPlay());
    }

   public void Settings()
    {
        //Do Something Little Nigga Dont Keep Staring At Me Remove Me And Start Coding Bitch
        Debug.Log("This Will Open Settings!");
        SettingsAS.Play();

    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("This Will Close The Game");
        QuitAS.Play();
    }
    
    IEnumerator DelayPlay()
    {
        PlayAS.Play();
        yield return new WaitForSeconds(1.4f);
        int randomSceneIndex = Random.Range(1, SceneManager.sceneCountInBuildSettings);
        SceneManager.LoadScene(randomSceneIndex);
        Debug.Log("Scene No. " + randomSceneIndex + " Loaded");
    }
}

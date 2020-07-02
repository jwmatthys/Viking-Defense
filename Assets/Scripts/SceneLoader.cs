using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] int timeToWait = 4;
    int currentSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex =  SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            // wait a few seconds
            StartCoroutine(WaitForTime(timeToWait));
        }
    }

    IEnumerator WaitForTime(int wait)
    {
        yield return new WaitForSeconds(wait);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void Quit() 
    {
        return;
    }
}

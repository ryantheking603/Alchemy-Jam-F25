using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour
{   
    [Header ("Scenes")]
    public string nextSceneName;

    [SerializeField] private float loadWaitTime;
    [SerializeField] private bool finalScene;
    private IEnumerator coroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (finalScene)
        {
            loadWaitTime = 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            ReloadScene();
        }
        if (Input.GetKeyDown("f"))
        {
            LoadNextLevel();
        }

        if (finalScene && KeyBehavior.KeyClaimed)
        {
            LoadNextLevel();
        }
    }

    void LoadSceneByName(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void ReloadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        coroutine = WaitAndReload(loadWaitTime, scene.name);
        ScreenFlashBehavior.ShouldFlash = true;
        StartCoroutine(coroutine);
    }

    public void LoadNextLevel()
    {
        coroutine = WaitAndReload(loadWaitTime, nextSceneName);
        if (nextSceneName.Length > 0)
        {
            ScreenFlashBehavior.ShouldFlash = true;
            StartCoroutine(coroutine);
        }
        else
        {
            Debug.LogWarning("No next level specified in Level Manager");
        }
    }

    IEnumerator WaitAndReload(float waitTime, string sceneToLoad)
    {
        yield return new WaitForSeconds(waitTime);
        LoadSceneByName(sceneToLoad);
    }
}

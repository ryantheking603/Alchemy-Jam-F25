using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour
{   
    [Header ("Scenes")]
    public string nextSceneName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            ReloadScene();
        }
    }

    void LoadSceneByName(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void ReloadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void LoadNextLevel()
    {
        if (nextSceneName.Length > 0)
        {
            LoadSceneByName(nextSceneName);
        }
        else
        {
            Debug.LogWarning("No next level specified in Level Manager");
        }
    }
}

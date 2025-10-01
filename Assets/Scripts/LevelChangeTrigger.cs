using UnityEngine;

public class LevelChangeTrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collideInfo)
    {
        LevelManager levelManager = GameObject.FindWithTag("LevelManager").GetComponent<LevelManager>();
        levelManager.LoadNextLevel();
    }
}

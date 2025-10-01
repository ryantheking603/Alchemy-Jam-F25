using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Spikes"))
        {
            LevelManager levelManager = GameObject.FindWithTag("LevelManager").GetComponent<LevelManager>();
            if (levelManager)
            {
                levelManager.ReloadScene();
            }
            else
            {
                Debug.Log("No Level Manager Specified By Tag");
            }
        }
    }
}

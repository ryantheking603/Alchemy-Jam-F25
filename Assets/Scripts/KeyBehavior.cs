using UnityEngine;

public class KeyBehavior : MonoBehaviour
{
    public static bool KeyClaimed {get; private set;}
    
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
        if (collideInfo.gameObject.CompareTag("Player"))
        {
            KeyClaimed = true;
            Destroy(gameObject);
        }
    }
}

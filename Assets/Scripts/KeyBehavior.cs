using UnityEngine;

public class KeyBehavior : MonoBehaviour
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
        if (collideInfo.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}

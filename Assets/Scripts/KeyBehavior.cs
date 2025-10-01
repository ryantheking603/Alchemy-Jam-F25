using UnityEngine;

public class KeyBehavior : MonoBehaviour
{
    public static bool KeyClaimed {get; private set;}
    [SerializeField] private AudioClip audioClip;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        KeyClaimed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collideInfo)
    {
        if (collideInfo.gameObject.CompareTag("Player"))
        {
            if (audioClip)
            {
                AudioSource.PlayClipAtPoint(audioClip, new Vector3(0, 0, 0));
            }
            else
            {
                Debug.Log("No audio clip given");
            }
            KeyClaimed = true;
            Destroy(gameObject);
        }
    }
}

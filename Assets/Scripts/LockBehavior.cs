using UnityEngine;

public class LockBehavior : MonoBehaviour
{
    [SerializeField] private AudioClip audioClip;

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
        if (KeyBehavior.KeyClaimed)
        {
            if (audioClip)
            {
                AudioSource.PlayClipAtPoint(audioClip, new Vector3(0, 0, 0));
            }
            else
            {
                Debug.Log("No audio clip given");
            }
            Destroy(gameObject);
        }
    }
}

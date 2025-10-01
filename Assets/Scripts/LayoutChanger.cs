using UnityEngine;

public class LayoutChanger : MonoBehaviour
{
    [SerializeField] private GameObject[] layouts;
    [SerializeField] private int layoutIndex;
    [SerializeField] private Color bgColor;
    [SerializeField] private AudioClip audioClip;
    private Camera camera;
    
    [Header ("Button Sprites")]
    [SerializeField] private GameObject buttonUp;
    [SerializeField] private GameObject buttonDown;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collideInfo)
    {
        if (collideInfo.gameObject.CompareTag("Player"))
        {
            foreach (GameObject layout in layouts)
            {
                layout.SetActive(false);
            }
            layouts[layoutIndex].SetActive(true);
            camera.backgroundColor = bgColor;
            SetButtonDown();
            if (audioClip)
            {
                AudioSource.PlayClipAtPoint(audioClip, new Vector3(0, 0, 0));
            }
            else
            {
                Debug.Log("No audio clip given");
            }
        }
    }

    void OnTriggerExit2D(Collider2D collideInfo)
    {
        SetButtonUp();
    }

    void SetButtonUp()
    {
        buttonUp.SetActive(true);
        buttonDown.SetActive(false);
    }

    void SetButtonDown()
    {
        buttonUp.SetActive(false);
        buttonDown.SetActive(true);
    }
}

using UnityEngine;

public class LayoutChanger : MonoBehaviour
{
    [SerializeField]
    private GameObject[] layouts;
    private int layoutIndex;

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
        foreach (GameObject layout in layouts)
        {
            layout.SetActive(false);
        }
        layouts[layoutIndex].SetActive(true);
    }
}

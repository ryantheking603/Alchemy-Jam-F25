using UnityEngine;

public class BackgroundChanger : MonoBehaviour
{
    [SerializeField]
    private Camera camera;
    [SerializeField]
    private Color[] colors;
    [SerializeField]
    private float changeSpeed;
    [SerializeField]
    private float hangTime;

    private int colorIndex;
    private float currentTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColor();
        ChangeTime();
    }

    void ChangeColor()
    {
        camera.backgroundColor = Color.Lerp(camera.backgroundColor, colors[colorIndex], changeSpeed * Time.deltaTime);
    }

    void ChangeTime()
    {
        if (currentTime <= 0)
        {
            colorIndex++;
            if (colorIndex >= colors.Length)
            {
                colorIndex = 0;
            }
            currentTime = hangTime;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }
}

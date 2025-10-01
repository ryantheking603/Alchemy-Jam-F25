using UnityEngine;

public class ScreenFlashBehavior : MonoBehaviour
{
    public static bool ShouldFlash {get; set;}
    [SerializeField] private float flashSpeed;
    private SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        if (!spriteRenderer)
        {
            Debug.Log("No Sprite Renderer Found");
        }
        spriteRenderer.color = new Color(255, 255, 255, 255);
        ShouldFlash = false;
    }

    void FixedUpdate()
    {
        if (ShouldFlash)
        {
            FlashScreen();
        }
        else
        {
            UnFlashScreen();
        }
    }

    void FlashScreen()
    {
        spriteRenderer.color = Color.Lerp(spriteRenderer.color, new Color(255, 255, 255, 255), flashSpeed / 50000);
    }

    void UnFlashScreen()
    {
        spriteRenderer.color = Color.Lerp(spriteRenderer.color, new Color(255, 255, 255, 0), flashSpeed * 2000);
    }
}

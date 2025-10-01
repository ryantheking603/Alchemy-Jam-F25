using UnityEngine;

public class AnimationChanger : MonoBehaviour
{
    [SerializeField] private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow)) {
            animator.SetBool("WalkBack", true);
            animator.SetBool("WalkForward", false);
            animator.SetBool("WalkLeft", false);
            animator.SetBool("WalkRight", false);
        }
        else if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow)) {
            animator.SetBool("WalkForward", true);
            animator.SetBool("WalkBack", false);
            animator.SetBool("WalkLeft", false);
            animator.SetBool("WalkRight", false);
        }
        else if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)) {
            animator.SetBool("WalkLeft", true);
            animator.SetBool("WalkForward", false);
            animator.SetBool("WalkBack", false);
            animator.SetBool("WalkRight", false);
        }
        else if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)) {
            animator.SetBool("WalkRight", true);
            animator.SetBool("WalkForward", false);
            animator.SetBool("WalkBack", false);
            animator.SetBool("WalkLeft", false);
        }
        else {
            animator.SetBool("WalkForward", false);
            animator.SetBool("WalkBack", false);
            animator.SetBool("WalkLeft", false);
            animator.SetBool("WalkRight", false);
        }
    }
}

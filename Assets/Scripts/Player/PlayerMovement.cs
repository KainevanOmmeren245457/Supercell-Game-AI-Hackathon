using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpHeight = 2f;

    // Remove constructor since MonoBehaviour uses Awake() or Start() instead
    void Start()
    {
        // Initialize values here if needed
    }

    public float GetSpeed()
    {
        return speed;
    }

    public float GetJumpHeight()
    {
        return jumpHeight;
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public void SetJumpHeight(float newJumpHeight)
    {
        jumpHeight = newJumpHeight;
    }
}
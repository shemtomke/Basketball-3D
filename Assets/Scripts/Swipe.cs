using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attach this script to the ball GameObject
public class Swipe : MonoBehaviour
{
    private Vector2 startInputPos;
    private Vector2 endInputPos;
    private Rigidbody rb;

    public float swipeForce = 5f;
    public float yForceMultiplier = 0.1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        HandleInput();
    }

    void HandleInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startInputPos = touch.position;
                    break;

                case TouchPhase.Ended:
                    endInputPos = touch.position;
                    SwipeAction();
                    break;
            }
        }
        else if (Input.GetMouseButtonDown(0))
        {
            startInputPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            endInputPos = Input.mousePosition;
            SwipeAction();
        }
    }

    void SwipeAction()
    {
        Vector2 swipeDirection = endInputPos - startInputPos;
        float verticalForce = swipeDirection.y * yForceMultiplier;
        Vector3 swipeForcePos = new Vector3(swipeDirection.x, verticalForce, swipeDirection.y).normalized * swipeForce;
        rb.isKinematic = false;
        rb.AddForce(Camera.main.transform.TransformDirection(swipeForcePos), ForceMode.Impulse);
        Destroy(gameObject, 5f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotatorTouch : MonoBehaviour
{
    private Vector2 startingPosition;    
    public GameObject selectedGameObject;
    [Range(0.1f, 2f)] public float rotationSensitivity = 0.1f;


    void Update()
    {
        TouchInput();
    }

    void TouchInput() {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startingPosition = touch.position;
                    break;

                case TouchPhase.Moved:
                    Vector2 touchDeltaPosition = touch.deltaPosition;
                    Vector3 gameObjectPosition = selectedGameObject.transform.position;

                    //Rotation in X axis
                    if (startingPosition.x > touch.position.x)
                    {
                        selectedGameObject.transform.RotateAround(gameObjectPosition, Vector3.down, -touchDeltaPosition.x * rotationSensitivity);
                    }
                    else if (startingPosition.x < touch.position.x)
                    {
                        selectedGameObject.transform.RotateAround(gameObjectPosition, Vector3.down, touchDeltaPosition.x * rotationSensitivity);
                    }

                    //Rotation in Y axis
                    if (startingPosition.y > touch.position.y)
                    {
                        selectedGameObject.transform.RotateAround(gameObjectPosition, Vector3.left, -touchDeltaPosition.y * rotationSensitivity);
                    }
                    else if (startingPosition.y < touch.position.y)
                    {
                        selectedGameObject.transform.RotateAround(gameObjectPosition, Vector3.left, touchDeltaPosition.y * rotationSensitivity);
                    }

                    break;

                case TouchPhase.Ended:
                    Debug.Log("Touch Phase Ended.");
                    break;
            }
        }
    }
}

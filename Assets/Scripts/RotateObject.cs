using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotatespeed = 10f;
    GameObject selectedGameObject;

    private void Start()
    {
        selectedGameObject = GetComponent<ObjectRotatorTouch>().selectedGameObject;
    }

    public void RotateHorizontally(int direction)
    {
        Vector3 gameObjectPosition = selectedGameObject.transform.position;
        selectedGameObject.transform.RotateAround(gameObjectPosition, Vector3.down,  rotatespeed*direction);
    }

    public void RotateVertically(int direction)
    {
        Vector3 gameObjectPosition = selectedGameObject.transform.position;
        selectedGameObject.transform.RotateAround(gameObjectPosition, Vector3.left, rotatespeed* direction);
    }
}

//void Update()
//{
//    if (Input.touchCount > 0)
//    {
//        Touch touch = Input.GetTouch(0);
//        switch (touch.phase)
//        {
//            case TouchPhase.Began:
//                startingPosition = touch.position;
//                break;

//            case TouchPhase.Moved:

//                //Rotation in X axis
//                if (startingPosition.x > touch.position.x)
//                {
//                    selectedGameObject.transform.Rotate(Vector3.back, -rotatespeed * Time.deltaTime);
//                }
//                else if (startingPosition.x < touch.position.x)
//                {
//                    selectedGameObject.transform.Rotate(Vector3.back, rotatespeed * Time.deltaTime);
//                }

//                //Rotation in Y axis
//                if (startingPosition.y > touch.position.y)
//                {
//                    selectedGameObject.transform.Rotate(Vector3.down, -rotatespeed * Time.deltaTime);
//                }
//                else if (startingPosition.y < touch.position.y)
//                {
//                    selectedGameObject.transform.Rotate(Vector3.down, rotatespeed * Time.deltaTime);
//                }

//                break;

//            case TouchPhase.Ended:
//                Debug.Log("Touch Phase Ended.");
//                break;
//        }
//    }
//}

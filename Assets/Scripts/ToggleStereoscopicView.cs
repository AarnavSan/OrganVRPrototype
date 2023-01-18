using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleStereoscopicView : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject camera_l;
    public GameObject camera_r;

    bool isStereoscopeOn = true;

   public void ToggleStereoscope()
    {
        isStereoscopeOn = !isStereoscopeOn;
        mainCamera.SetActive(!isStereoscopeOn);
        camera_l.SetActive(isStereoscopeOn);
        camera_r.SetActive(isStereoscopeOn);
    }
}
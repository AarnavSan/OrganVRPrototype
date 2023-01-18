using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleStereoscopicView : MonoBehaviour
{
    public Camera mainCamera;
    public Camera camera_l;
    public Camera camera_r;
    bool isStereoscopeOn = true;
   public void ToggleStereoscope()
    {
        isStereoscopeOn = !isStereoscopeOn;
        mainCamera.enabled = !isStereoscopeOn;
        camera_l.enabled = isStereoscopeOn;
        camera_r.enabled = isStereoscopeOn;
    }
}

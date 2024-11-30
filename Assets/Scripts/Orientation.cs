using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetOrientation : MonoBehaviour
{
    void Start()
    {
        // Set the screen orientation to landscape when the scene starts
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    void OnDisable()
    {
        // Optionally reset the orientation when the scene is unloaded
        Screen.orientation = ScreenOrientation.AutoRotation;
    }
}


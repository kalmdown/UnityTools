using UnityEngine;
using UnityEditor;

public class SwitchCameras
{
    public static Camera Camera_Close = GameObject.FindGameObjectWithTag("Camera_Close").GetComponent(typeof(Camera)) as Camera;
    public static Camera Camera_Far = GameObject.FindGameObjectWithTag("Camera_Far").GetComponent(typeof(Camera)) as Camera;

    [MenuItem ("My Cameras/Switch to Close Camera &1")]
    static void enableCloseCam() 
    {
        Camera_Close.enabled = true;
        Camera_Far.enabled = false;
    }

    [MenuItem ("My Cameras/Switch to Far Camera &2")] 
    static void enableFarCam() 
    {
        Camera_Close.enabled = false;
        Camera_Far.enabled = true;
    }
}
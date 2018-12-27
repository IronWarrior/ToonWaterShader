using UnityEngine;

public class CameraDepthTextureMode : MonoBehaviour 
{
    [SerializeField]
    DepthTextureMode depthTextureMode;

    private void OnValidate()
    {
        GetComponent<Camera>().depthTextureMode = depthTextureMode;
    }
}

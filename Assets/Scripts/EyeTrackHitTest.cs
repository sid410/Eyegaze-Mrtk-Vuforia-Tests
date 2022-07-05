using UnityEngine;
using Microsoft.MixedReality.Toolkit;

public class EyeTrackHitTest : MonoBehaviour
{
    public GameObject cubeGO;

    private void Update()
    {
        var eyeGazeProvider = CoreServices.InputSystem?.EyeGazeProvider;
        if (eyeGazeProvider != null)
        {
            RaycastHit hitInfo;
            Physics.Raycast(eyeGazeProvider.GazeOrigin, eyeGazeProvider.GazeDirection, out hitInfo);
            cubeGO.transform.position = hitInfo.point;
        }
    }
}

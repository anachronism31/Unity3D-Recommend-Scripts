using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera firstPersonCamera; // First-person camera object
    public Camera thirdPersonCamera; // Third-person camera object

    private void Start()
    {
        // Enable the first-person camera initially
        EnableFirstPersonCamera();
    }

    private void Update()
    {
        // Check for camera switch when the "C" key is pressed
        if (Input.GetKeyDown(KeyCode.C))
        {
            // If the first-person camera is enabled, switch to the third-person camera and disable the first-person camera
            if (firstPersonCamera.enabled)
            {
                EnableThirdPersonCamera();
            }
            // If the third-person camera is enabled, switch to the first-person camera and disable the third-person camera
            else if (thirdPersonCamera.enabled)
            {
                EnableFirstPersonCamera();
            }
        }
    }

    private void EnableFirstPersonCamera()
    {
        firstPersonCamera.enabled = true; // Enable the first-person camera
        thirdPersonCamera.enabled = false; // Disable the third-person camera
    }

    private void EnableThirdPersonCamera()
    {
        firstPersonCamera.enabled = false; // Disable the first-person camera
        thirdPersonCamera.enabled = true; // Enable the third-person camera
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Look : MonoBehaviour
{


    [SerializeField] Transform playerCamera = null;
    [SerializeField] float mouseSensitivity = 3.5f;

    [SerializeField] bool lockCursor = true;
    [SerializeField] bool playerDeath;

    float cameraPitch = 0.0f;
    void Start()
    {
        if (lockCursor) // Switches the cursor off.
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMouseLook();
    }

    void UpdateMouseLook() 
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        cameraPitch -= mouseDelta.y * mouseSensitivity;

        cameraPitch = Mathf.Clamp(cameraPitch, -90.0f, 90.0f);


        playerCamera.localEulerAngles = Vector3.right * cameraPitch;

        transform.Rotate(Vector3.up * mouseDelta.x * mouseSensitivity);
    }

    public void Death() 
    {
        if (playerDeath == true) 
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            Debug.Log("Testing Unlock of Mouse Cursor");
        }
    }

    public void ResetMouseView() 
    {
        
    }
}

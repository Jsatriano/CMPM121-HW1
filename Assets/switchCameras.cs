using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCameras : MonoBehaviour
{
    public List<Camera> Cameras;

    // Start is called before the first frame update
    void Start()
    {
        EnableCamera(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            EnableCamera(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            EnableCamera(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            EnableCamera(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4)) {
            EnableCamera(3);
        }
    }

    // Enables camera of user input and disables the rest
    private void EnableCamera(int n) 
    {
        for (int i = 0; i < Cameras.Count; i += 1) {
            if (i == n) {
                Cameras[i].enabled = true;
            }
            else {
                Cameras[i].enabled = false;
            }
        }
    }
}

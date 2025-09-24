using UnityEngine;

public class SwapCamera : MonoBehaviour
{
    public Camera cameraMain;
    public Camera cameraSec;

    private bool changToMain;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        changToMain = true;   
        cameraMain.enabled = true;
        cameraSec.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SawpCamera();
        }

    }

    void SawpCamera()
    {
        changToMain = !changToMain;
        cameraMain.enabled = changToMain;
        cameraSec.enabled = !changToMain;
    }
}

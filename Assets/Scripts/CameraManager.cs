using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera camera1;
    [SerializeField] CinemachineVirtualCamera camera2;
    [SerializeField] CinemachineVirtualCamera camera3;

    // Start is called before the first frame update
    void Start()
    {
        camera1.Priority = 20;
        camera2.Priority = 10;
        camera3.Priority = 10;
    }

   /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("camera1")) 
        {
            camera1.Priority = 20;
            camera2.Priority = 10;
            camera3.Priority = 10;
        }

        if (collision.gameObject.CompareTag("camera2"))
        {
            camera1.Priority = 10;
            camera2.Priority = 20;
            camera3.Priority = 10;
        }
        if (collision.gameObject.CompareTag("camera3"))
        {
            camera1.Priority = 10;
            camera2.Priority = 10;
            camera3.Priority = 20;
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("camera1"))
        {
            Debug.Log("its happening");
            camera1.Priority = 20;
            camera2.Priority = 10;
            camera3.Priority = 10;
        }

        if (other.gameObject.CompareTag("camera2"))
        {
            Debug.Log("its happening");

            camera1.Priority = 10;
            camera2.Priority = 20;
            camera3.Priority = 10;
        }
        if (other.gameObject.CompareTag("camera3"))
        {
            Debug.Log("its happening");

            camera1.Priority = 10;
            camera2.Priority = 10;
            camera3.Priority = 20;
        }
    }
}

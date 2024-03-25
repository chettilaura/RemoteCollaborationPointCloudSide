using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class EnvironmentSwitch : MonoBehaviour
{

    public GameObject[] pointCloudMeshes;
    public GameObject ricohThetaMesh;
    

    private bool environmentswitch = true; // true (360) & false (pointcloud)

    void Update()
    {
    
        
        if ( OVRInput.GetDown(OVRInput.RawButton.A) )
        {
            if (environmentswitch == true)
            {
                environmentswitch = false;
                Debug.Log("switched to pointcloud");

                ricohThetaMesh.GetComponent<MeshRenderer>().enabled = false;

                for (int i = 0; i < pointCloudMeshes.Length; i++)
                {
                    pointCloudMeshes[i].GetComponent<MeshRenderer>().enabled = true;
                }
            }
            else 
            {
                environmentswitch = true;
                Debug.Log("switched to 360");

                for (int i = 0; i < pointCloudMeshes.Length; i++)
                {
                    pointCloudMeshes[i].GetComponent<MeshRenderer>().enabled = false;
                }

                ricohThetaMesh.GetComponent<MeshRenderer>().enabled = true;

            }


        }

    }
 
}

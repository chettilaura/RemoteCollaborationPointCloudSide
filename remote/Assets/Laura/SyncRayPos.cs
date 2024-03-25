using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SyncRayPos : MonoBehaviour
{
    public GameObject controllerRay;
    //public UnityEvent OnRayEvent = new UnityEvent();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controllerRay!= null)
        {
            transform.position = controllerRay.transform.position;
            transform.rotation = controllerRay.transform.rotation;

        }
        //if(OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        //{
        //    OnRayEvent?.Invoke();
        //}
        
    }
}

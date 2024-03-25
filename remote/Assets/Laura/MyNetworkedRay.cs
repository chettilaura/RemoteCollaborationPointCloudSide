using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ubiq.Messaging;

public class MyNetworkedRay : MonoBehaviour
{
    NetworkContext context;
    private bool rayswitch = false;
    public CubeMaterialsSwitch cubeMaterialsSwitch;

    void Start()
    {
        context = NetworkScene.Register(this);
    }

    private struct Message
    {
        public Vector3 position;
        public Quaternion rotation;
        public string name;
    }


    public void RayInteraction()
    {
        Debug.Log("Trigger pressed, cube is: " + this.gameObject.name);
        context.SendJson(new Message()
        {
            position = transform.localPosition,
            rotation = transform.localRotation,
            name = this.gameObject.name
        });

       
        if (rayswitch == false)
        {
            Debug.Log("rayswitch is selected");
            rayswitch = true;
            cubeMaterialsSwitch.ChangeMaterial();
        }
        else
        {
            Debug.Log("rayswitch is deselected");
            rayswitch = false;
            cubeMaterialsSwitch.ChangeMaterial();
        }



    }



    public void ProcessMessage(ReferenceCountedSceneGraphMessage message)
    {
        // analyze the received message
        var m = message.FromJson<Message>();


    }

}

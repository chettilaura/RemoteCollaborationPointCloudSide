using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ubiq.Messaging;

public class MyNetworkedMenu : MonoBehaviour
{
    NetworkContext context;
    private bool menuswitch = false;
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


        if (menuswitch == false)
        {
            Debug.Log("close menu is selected");
            menuswitch = true;
            cubeMaterialsSwitch.ChangeMaterial();
        }
        else
        {
            Debug.Log("close menu is deselected");
            menuswitch = false;
            cubeMaterialsSwitch.ChangeMaterial();
        }



    }



    public void ProcessMessage(ReferenceCountedSceneGraphMessage message)
    {
        // analyze the received message
        var m = message.FromJson<Message>();


    }
}

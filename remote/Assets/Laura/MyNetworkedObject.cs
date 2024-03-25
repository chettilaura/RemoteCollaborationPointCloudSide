using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ubiq.Messaging;

public class MyNetworkedObject : MonoBehaviour
{
    NetworkContext context;
    private bool cube1 = false;
    private bool cube2 = false;
    private bool cube3 = false;
    private bool cube4 = false;
    private bool cube5 = false;
    private bool cube6 = false;
    private bool cube7 = false;
    private bool cube8 = false;
    private bool cube9 = false;
    private bool cube10 = false;
    private bool cube11 = false;
    private bool cube12 = false;
    private bool cube13 = false;
    private bool cube14 = false;
    private bool cube15 = false;
    private bool cube16 = false;
    private bool cube17 = false;
    private bool cube18 = false;
    private bool cube19 = false;
    private bool cube20 = false;

    public CubeMaterialsSwitch cubeMaterialsSwitch;


    void Start()
    {
        context = NetworkScene.Register(this);
    }

    Vector3 lastPosition;


    void Update()
    {
        if (lastPosition != transform.localPosition && this.gameObject.name == "ray")
        {
            lastPosition = transform.localPosition;
            context.SendJson(new Message()
            {
                position = transform.localPosition,
                rotation = transform.localRotation,
                name = this.gameObject.name
            });
        }
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


        switch (this.gameObject.name)
        {
            case "Cube1":
                if (cube1 == false)
                {
                    Debug.Log("cube1 is selected");
                    cube1 = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube1 is deselected");
                    cube1 = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube2":
                if (cube2 == false)
                {
                    Debug.Log("cube2 is selected");
                    cube2 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube2 is deselected");
                    cube2 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube3":
                if (cube3 == false)
                {
                    Debug.Log("cube3 is selected");
                    cube3 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube3 is deselected");
                    cube3 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube4":
                if (cube4 == false)
                {
                    Debug.Log("cube4 is selected");
                    cube4 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube4 is deselected");
                    cube4 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube5":
                if (cube5 == false)
                {
                    Debug.Log("cube5 is selected");
                    cube5 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube5 is deselected");
                    cube5 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube6":
                if (cube6 == false)
                {
                    Debug.Log("cube6 is selected");
                    cube6 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube6 is deselected");
                    cube6 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube7":
                if (cube7 == false)
                {
                    Debug.Log("cube7 is selected");
                    cube7 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube7 is deselected");
                    cube7 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube8":
                if (cube8 == false)
                {
                    Debug.Log("cube8 is selected");
                    cube8 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube8 is deselected");
                    cube8 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube9":
                if (cube9 == false)
                {
                    Debug.Log("cube9 is selected");
                    cube9 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube9 is deselected");
                    cube9 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube10":
                if (cube10 == false)
                {
                    Debug.Log("cube10 is selected");
                    cube10 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube10 is deselected");
                    cube10 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube11":  
                if (cube11 == false)
                {
                    Debug.Log("cube11 is selected");
                    cube11 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube11 is deselected");
                    cube11 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube12":
                if (cube12 == false)
                {
                    Debug.Log("cube12 is selected");
                    cube12 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube12 is deselected");
                    cube12 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube13":
                if (cube13 == false)
                {
                    Debug.Log("cube13 is selected");
                    cube13 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube13 is deselected");
                    cube13 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube14":
                if (cube14 == false)
                {
                    Debug.Log("cube14 is selected");
                    cube14 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube14 is deselected");
                    cube14 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube15":
                if (cube15 == false)
                {
                    Debug.Log("cube15 is selected");
                    cube15 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube15 is deselected");
                    cube15 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube16":
                if (cube16 == false)
                {
                    Debug.Log("cube16 is selected");
                    cube16 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube16 is deselected");
                    cube16 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube17":
                if (cube17 == false)
                {
                    Debug.Log("cube17 is selected");
                    cube17 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube17 is deselected");
                    cube17 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube18":
                if (cube18 == false)
                {
                    Debug.Log("cube18 is selected");
                    cube18 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube18 is deselected");
                    cube18 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube19":
                if (cube19 == false)
                {
                    Debug.Log("cube19 is selected");
                    cube19 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube19 is deselected");
                    cube19 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "Cube20":
                if (cube20 == false)
                {
                    Debug.Log("cube20 is selected");
                    cube20 = true;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("cube20 is deselected");
                    cube20 = false;
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;

            default:
                Debug.Log("No cube selected");
                break;
        }
    }





    private struct Message
    {
        public Vector3 position;
        public Quaternion rotation;
        public string name;
    }


    public void ProcessMessage(ReferenceCountedSceneGraphMessage message)
    {
        // analyze the received message
        var m = message.FromJson<Message>();


        if(m.name == "ray")
        {
            Debug.Log("shared ray moving"); 
                                           
            transform.localPosition = m.position;
            transform.localRotation = m.rotation;

            // Make sure the logic in Update doesn't trigger as a result of this message
            lastPosition = transform.localPosition;
        }

       
    }
}
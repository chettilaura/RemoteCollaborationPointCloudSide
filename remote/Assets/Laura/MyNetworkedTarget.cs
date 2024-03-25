using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ubiq.Messaging;


public class MyNetworkedTarget : MonoBehaviour
{
    NetworkContext context;
    private bool targetA = false;
    private bool targetB = false;
    private bool targetC = false;
    private bool targetD = false;
    private bool targetE = false;
    private bool targetF = false;
    private bool targetG = false;
    private bool targetH = false;
    private bool targetI = false;
    private bool targetJ = false;
    private bool targetK = false;
    private bool targetL = false;
    private bool targetM = false;
    private bool targetN = false;
    private bool targetO = false;
    private bool targetP = false;
    private bool targetQ = false;
    private bool targetR = false;
    private bool targetS = false;
    private bool targetT = false;

    public CubeMaterialsSwitch cubeMaterialsSwitch;

    void Start()
    {
        context = NetworkScene.Register(this);
    }


    public void RayInteraction()
    {
        Debug.Log("Trigger pressed, target is: " + this.gameObject.name);
        context.SendJson(new Message()
        {
            position = transform.localPosition,
            rotation = transform.localRotation,
            name = this.gameObject.name
        });


        switch (this.gameObject.name)
        {
            case "TargetA":
                if (targetA == false)
                {
                    Debug.Log("targetA is selected");
                    targetA = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetA is deselected");
                    targetA = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetB":
                if (targetB == false)
                {
                    Debug.Log("targetB is selected");
                    targetB = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetB is deselected");
                    targetB = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetC":
                if (targetC == false)
                {
                    Debug.Log("targetC is selected");
                    targetC = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetC is deselected");
                    targetC = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetD":
                if (targetD == false)
                {
                    Debug.Log("targetD is selected");
                    targetD = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetD is deselected");
                    targetD = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetE":
                if (targetE == false)
                {
                    Debug.Log("targetE is selected");
                    targetE = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetE is deselected");
                    targetE = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetF":
                if (targetF == false)
                {
                    Debug.Log("targetF is selected");
                    targetF = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetF is deselected");
                    targetF = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetG":
                if (targetG == false)
                {
                    Debug.Log("targetG is selected");
                    targetG = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetG is deselected");
                    targetG = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetH":
                if (targetH == false)
                {
                    Debug.Log("targetH is selected");
                    targetH = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetH is deselected");
                    targetH = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetI":
                if (targetI == false)
                {
                    Debug.Log("targetI is selected");
                    targetI = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetI is deselected");
                    targetI = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetJ":
                if (targetJ == false)
                {
                    Debug.Log("targetJ is selected");
                    targetJ = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetJ is deselected");
                    targetJ = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetK":
                if (targetK == false)
                {
                    Debug.Log("targetK is selected");
                    targetK = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetK is deselected");
                    targetK = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetL":
                if (targetL == false)
                {
                    Debug.Log("targetL is selected");
                    targetL = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetL is deselected");
                    targetL = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetM":
                if (targetM == false)
                {
                    Debug.Log("targetM is selected");
                    targetM = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetM is deselected");
                    targetM = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetN":
                if (targetN == false)
                {
                    Debug.Log("targetN is selected");
                    targetN = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetN is deselected");
                    targetN = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetO":
                if (targetO == false)
                {
                    Debug.Log("targetO is selected");
                    targetO = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetO is deselected");
                    targetO = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetP":
                if (targetP == false)
                {
                    Debug.Log("targetP is selected");
                    targetP = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetP is deselected");
                    targetP = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetQ":
                if (targetQ == false)
                {
                    Debug.Log("targetQ is selected");
                    targetQ = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetQ is deselected");
                    targetQ = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetR":
                if (targetR == false)
                {
                    Debug.Log("targetR is selected");
                    targetR = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetR is deselected");
                    targetR = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetS":
                if (targetS == false)
                {
                    Debug.Log("targetS is selected");
                    targetS = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetS is deselected");
                    targetS = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;
            case "TargetT":
                if (targetT == false)
                {
                    Debug.Log("targetT is selected");
                    targetT = true;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                else
                {
                    Debug.Log("targetT is deselected");
                    targetT = false;
                    //call the function ChangeMaterial in the script called CubeMaterialsSwitch attached to the gameObject 
                    cubeMaterialsSwitch.ChangeMaterial();
                }
                break;

            default:
                Debug.Log("No target selected");
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

    }




}

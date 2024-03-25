using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMenuSwitch : MonoBehaviour
{

    public GameObject menu;
    private bool menuswitch = true; //menus tarts active

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            if (menuswitch == true)
            {
                menuswitch = false;
                Debug.Log("my menu disabled");
                menu.SetActive(false);
            }
            else
            {
                menuswitch = true;
                Debug.Log("my menu enabled");
                menu.SetActive(true);
            }
        }


    }


}

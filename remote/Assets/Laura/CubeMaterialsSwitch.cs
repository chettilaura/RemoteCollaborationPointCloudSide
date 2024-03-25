using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMaterialsSwitch : MonoBehaviour
{
    private bool selected = false;
    public Material materialNormalCube;
    public Material materialSelectedCube;

    public void ChangeMaterial ()
    {
        if (selected)
        {
            gameObject.GetComponent<MeshRenderer>().material = materialNormalCube;
            selected = false;
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material = materialSelectedCube;
            selected = true;

            StartCoroutine(waitseconds(5));

        }
    }

    IEnumerator waitseconds(int secs)
    {
        yield return new WaitForSeconds(secs);
        gameObject.GetComponent<MeshRenderer>().material = materialNormalCube;
        selected = false;
    }


}

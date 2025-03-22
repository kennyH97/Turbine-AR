using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class MeshToggle : MonoBehaviour
{
    public GameObject TurbineObject;
    private bool isActive = true;
    public void Toggle()
    {
        if (isActive)
        {
            TurbineObject.SetActive(false);
            isActive = false;
        }
        else 
        {
            TurbineObject.SetActive(true);
            isActive = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnloadObjectOnButton : MonoBehaviour
{
    public GameObject objectToUnload;

    // This method is called when the button is pressed
    public void UnloadObject()
    {
        if (objectToUnload != null)
        {
            Destroy(objectToUnload);
            Debug.Log("Object unloaded!");
        }
        else
        {
            Debug.LogWarning("Object to unload is not assigned!");
        }
    }
}

using System.Collections.Generic;
using UnityEngine;

public class UnloadObjectsOnButton : MonoBehaviour
{
    public List<GameObject> objectsToUnload = new List<GameObject>();

    // This method is called when the button is pressed
    public void UnloadObjects()
    {
        foreach (GameObject obj in objectsToUnload)
        {
            if (obj != null)
            {
                Destroy(obj);
                Debug.Log("Object unloaded: " + obj.name);
            }
            else
            {
                Debug.LogWarning("Object to unload is not assigned!");
            }
        }
    }
}

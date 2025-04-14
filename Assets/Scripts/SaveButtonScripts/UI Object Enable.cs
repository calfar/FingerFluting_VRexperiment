using System.Collections.Generic;
using UnityEngine;

public class EnableObjectsOnButton : MonoBehaviour
{
    public List<GameObject> objectsToEnable = new List<GameObject>();

    // This method is called when the button is pressed
    public void EnableObjects()
    {
        // Ensure the list is not empty
        if (objectsToEnable.Count == 0)
        {
            Debug.LogWarning("No objects to enable!");
            return;
        }

        // Enable each object in the list
        foreach (GameObject obj in objectsToEnable)
        {
            if (obj != null)
            {
                obj.SetActive(true);
                Debug.Log("Object enabled: " + obj.name);
            }
            else
            {
                Debug.LogWarning("Object to enable is not assigned!");
            }
        }
    }
}

using System.Collections.Generic;
using UnityEngine;

public class LoadObjectsOnButton : MonoBehaviour
{
    public List<GameObject> objectPrefabsToLoad = new List<GameObject>();
    private List<GameObject> loadedObjects = new List<GameObject>();

    // This method is called when the button is pressed
    public void LoadObjects()
    {
        // Ensure the list is not empty
        if (objectPrefabsToLoad.Count == 0)
        {
            Debug.LogWarning("No objects to load!");
            return;
        }

        // Instantiate each object in the list
        foreach (GameObject prefab in objectPrefabsToLoad)
        {
            GameObject loadedObject = Instantiate(prefab, Vector3.zero, Quaternion.identity);
            loadedObjects.Add(loadedObject);
            Debug.Log("Object loaded: " + loadedObject.name);
        }
    }
}

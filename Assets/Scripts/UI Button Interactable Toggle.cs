using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;

public class ToggleButtonInteractivity : MonoBehaviour
{
    public List<GameObject> targetObjects = new List<GameObject>();

    // This method is called when the button is pressed
    public void ToggleInteractivity(bool newInteractability)
    {
        foreach (GameObject obj in targetObjects)
        {
            if (obj != null)
            {
                // Try to get the Button component on the specified GameObject
                Button button = obj.GetComponent<Button>();

                if (button != null)
                {
                    // Set the interactable property
                    button.interactable = newInteractability;

                    Debug.Log("Button interactable status: " + button.interactable);
                }
                else
                {
                    Debug.LogWarning("Button component not found on the specified GameObject: " + obj.name);
                }
            }
            else
            {
                Debug.LogWarning("Target GameObject not assigned!");
            }
        }
    }
}

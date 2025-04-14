using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;

public class SetButtonInteractivityFalse : MonoBehaviour
{
    public List<Button> targetButtons = new List<Button>();

    // This method is called when the button is pressed
    public void SetButtonsInteractivityFalse()
    {
        foreach (Button button in targetButtons)
        {
            if (button != null)
            {
                // Set the interactable property to false
                button.interactable = false;

                Debug.Log("Button interactable status set to false: " + button.gameObject.name);
            }
            else
            {
                Debug.LogWarning("Button component not found on a specified GameObject!");
            }
        }
    }
}

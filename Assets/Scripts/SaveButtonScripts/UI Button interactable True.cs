using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;

public class SetButtonInteractivityTrue : MonoBehaviour
{
    public List<Button> targetButtons = new List<Button>();

    // This method is called when the button is pressed
    public void SetButtonsInteractivityTrue()
    {
        foreach (Button button in targetButtons)
        {
            if (button != null)
            {
                // Set the interactable property to true
                button.interactable = true;

                Debug.Log("Button interactable status set to true: " + button.gameObject.name);
            }
            else
            {
                Debug.LogWarning("Button component not found on a specified GameObject!");
            }
        }
    }
}

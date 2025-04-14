using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScaleControllerSingle : MonoBehaviour
{
    public Transform targetObject; // Reference to the object you want to scale
    public TMP_InputField scaleInputField; // Reference to the TextMeshPro InputField

    public void UpdateScale()
    {
        if (targetObject == null)
        {
            Debug.LogError("Target object not set!");
            return;
        }

        if (scaleInputField != null && float.TryParse(scaleInputField.text, out float scaleValue))
        {
            // Parse the TextMeshPro InputField text to a float and set the object's scale
            targetObject.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
        }
        else
        {
            Debug.LogError("Invalid input! Please enter a valid number.");
        }
    }
}

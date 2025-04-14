using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScaleController : MonoBehaviour
{
    public Transform[] targetObjects; // Array of objects you want to scale
    public TMP_InputField scaleInputField; // Reference to the TextMeshPro InputField

    void Awake()
    {
        // Assuming you want an array of size 0 initially
        targetObjects = new Transform[5];
    }

    public void UpdateScale()
    {
        if (targetObjects == null || targetObjects.Length == 0)
        {
            Debug.LogError("Target objects not set!");
            return;
        }

        if (scaleInputField != null && float.TryParse(scaleInputField.text, out float scaleValue))
        {
            // Parse the TextMeshPro InputField text to a float and set the scale for each object
            foreach (Transform targetObjects in targetObjects)
            {
                if (targetObjects != null)
                {
                    targetObjects.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
                }
                else
                {
                    Debug.LogWarning("Null object in targetObjects array. Check your references.");
                }
            }
        }
        else
        {
            Debug.LogError("Invalid input! Please enter a valid number.");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SphereRadiusController : MonoBehaviour
{
    public TMP_InputField radiusInput;
    public GameObject sphere;

    private void Start()
    {
        // Add listener to the TMP Input Field's onValueChanged event
        radiusInput.onValueChanged.AddListener(UpdateRadius);
    }

    private void UpdateRadius(string newRadius)
    {
        if (float.TryParse(newRadius, out float radiusValue))
        {
            // Divide the parsed float value by 100
            radiusValue /= 200f;

            // Update the sphere collider radius
            sphere.GetComponent<SphereCollider>().radius = radiusValue;
        }
        else
        {
            Debug.LogError("Invalid radius input!");
        }
    }
}

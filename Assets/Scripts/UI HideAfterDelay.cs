using UnityEngine;
using UnityEngine.UI;

public class HideAfterDelay : MonoBehaviour
{
    // Time in seconds before the UI element disappears
    public float delay = 2.0f;

    private void Start()
    {
        // Invoke the HideUI method after the specified delay
        Invoke("HideUI", delay);
    }

    private void HideUI()
    {
        // Disable the UI element
        gameObject.SetActive(false);
    }
}
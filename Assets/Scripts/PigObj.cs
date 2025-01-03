using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class PigObj : MonoBehaviour
{
    public Canvas textCanvas;
    public string grabMessage = "You grabbed the object!";
    public string releaseMessage = "You released the object!";

    private void Awake()
    {
        // 캔버스를 초기 비활성화
        if (textCanvas != null)
        {
            textCanvas.enabled = false;
        }
    }

    private void OnEnable()
    {
        var interactable = GetComponent<XRGrabInteractable>();
        if (interactable != null)
        {
            interactable.selectEntered.AddListener(OnGrab);
            interactable.selectExited.AddListener(OnRelease);
        }
    }

    private void OnDisable()
    {
        var interactable = GetComponent<XRGrabInteractable>();
        if (interactable != null)
        {
            interactable.selectEntered.RemoveListener(OnGrab);
            interactable.selectExited.RemoveListener(OnRelease);
        }
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        if (textCanvas != null)
        {
            textCanvas.enabled = true;
            UpdateText(grabMessage);
        }
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        if (textCanvas != null)
        {
            textCanvas.enabled = true;
            UpdateText(releaseMessage);
        }
    }

    private void UpdateText(string message)
    {
        var textComponent = textCanvas.GetComponentInChildren<Text>();
        if (textComponent != null)
        {
            textComponent.text = message;
        }
    }
}

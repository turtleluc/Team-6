using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aanenuit : MonoBehaviour
{

    private void Start()
    {
        PowerButton.PowerButtonClicked += TurnButtonOnAndOff;
        thisButton = GetComponent<Button>();
    }


    private void TurnButtonOnAndOff(bool isOn)
    {
        thisButton.interactable = isOn;
    }

    private void OnDestroy()
    {
        PowerButton.PowerButtonClicked -= TurnButtonOnAndOff;
    }
}

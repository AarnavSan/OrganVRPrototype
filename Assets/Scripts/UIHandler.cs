using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIHandler : MonoBehaviour
{
    public GameObject player;

    public Slider sensitivitySlider;
    public TextMeshProUGUI sensitivitySliderText;

    public GameObject menuPanel;
    public GameObject settingsPanel;

    HamburgerButtonDisappear buttonDisappear;
    public bool menuOpened = false;

    // Start is called before the first frame update
    void Start()
    {
        GetReferences();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetReferences()
    {
        buttonDisappear = GetComponent<HamburgerButtonDisappear>();
    }

    public void HamburgerPressed()
    {
        buttonDisappear.HamburgerButtonPressed();
    }

    public void ToggleMenu()
    {
        menuOpened = !menuOpened;
        menuPanel.SetActive(menuOpened);
    }

    public void ChangeSensitivity()
    {
        player.GetComponent<ObjectRotatorTouch>().rotationSensitivity = sensitivitySlider.value;
        sensitivitySliderText.text = "Sensitivity: " + (int)(sensitivitySlider.value * 100);
    }
}
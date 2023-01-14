using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HamburgerButtonDisappear : MonoBehaviour
{
    Image image;
    TextMeshProUGUI text;
    UIHandler uiHandler;

    [SerializeField] float duration = 1.0f;
    bool faded =  false;
    bool justClicked = false;

    // Start is called before the first frame update
    void Start()
    {
        GetReferences();
    }

    // Update is called once per frame
    void Update()
    {
        if (!uiHandler.menuOpened && !faded && !justClicked)
        {
            FadeOutButton();
        }
    }

    void GetReferences()
    {
        image = GetComponent<Image>();
        uiHandler = GetComponent<UIHandler>();
        text = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void HamburgerButtonPressed()
    {
        
        if (faded)
        {
            Color c = image.color;
             c.a = 1;
            image.color = c;

            text.color = new Color(0,0,0,1);

            faded = false;
            justClicked = true;
            Invoke("ActivateFadeOutCheck", 5.0f);
        }
        else
        {
            uiHandler.ToggleMenu();
            justClicked = true;
        }
    }

    void FadeOutButton()
    {
        StartCoroutine(FadeOut());
        faded = true;
    }

    IEnumerator FadeOut()
    {
        Color c = image.color;
        Color c2 = text.color;
        float time = 0f;
        while (time < duration)
        {
            time += Time.deltaTime;
            c.a = 1 - (time / duration);
            c2.a = 1 - (time / duration);
            yield return null;
            image.color = c;
            text.color = c2;
        }
    }

    void ActivateFadeOutCheck()
    {
        justClicked = false;
    }
}

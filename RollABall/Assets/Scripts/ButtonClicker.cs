using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements; 

public class ButtonClicker : MonoBehaviour
{
    UIDocument buttonDocument;
    Button uiButton;
    // Start is called before the first frame update
    UIDocument titleDocument;
    TextElement uiTitle;
    void OnEnable()
    {
        buttonDocument = GetComponent<UIDocument>();
        uiButton = buttonDocument.rootVisualElement.Q("StartGameButton") as Button;
        uiButton.RegisterCallback<ClickEvent>(OnButtonClick);
        titleDocument = GetComponent<UIDocument>();
        uiTitle = titleDocument.rootVisualElement.Q("StartTitle") as TextElement;
    }
    public void OnButtonClick(ClickEvent evt)
    {
        buttonDocument.enabled = false;
        //BroadcastMessage("StartGamePressed");
        uiTitle.SetEnabled(false);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

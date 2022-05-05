using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class SceneSwitch : MonoBehaviour
{

    public static bool inCharacterView;
    public static bool inSceneView;

    public GameObject exitButton;

    YarnInteractable yarnInteractable;



    private void Start()
    {
        exitButton = GameObject.FindGameObjectWithTag("Exit");
        exitButton.SetActive(false);

        yarnInteractable = FindObjectOfType<YarnInteractable>();
    }

    private void Update()
    {
        if (YarnInteractable.conversationActive)
        {
            inCharacterView = true;
            inSceneView = false;
            ShowExitButton();
        }
        else
        {
            inCharacterView = false;
            inSceneView = true;
            HideExitButton();

        }
    }

    public void ShowExitButton()
    {
        exitButton.SetActive(true);
    }

    public void HideExitButton()
    {
        exitButton.SetActive(false);
    }

    public void CloseConversation()
    {
        //Interactable.EndConversation();
    }


}

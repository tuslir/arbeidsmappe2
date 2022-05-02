using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class SceneSwitch : MonoBehaviour
{

    public static bool inCharacterView;
    public static bool inSceneView;

    //public GameObject exitButton;



    private void Start()
    {
        //exitButton = GameObject.FindGameObjectWithTag("Exit");

    }

    private void Update()
    {
        if (YarnInteractable.conversationActive)
        {
            inCharacterView = true;
            inSceneView = false;
            //HideExitButton();
        }
        else
        {
            inCharacterView = false;
            inSceneView = true;
            //ShowExitButton();
        }
    }

    public void ShowExitButton()
    {
        //exitButton.SetActive(true);
    }

    public void HideExitButton()
    {
        //exitButton.SetActive(false);
    }




}

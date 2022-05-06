using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class SceneSwitch : MonoBehaviour
{

    public static bool inCharacterView;
    public static bool inSceneView;



    private void Start()
    {

    }

    private void Update()
    {
        if (YarnInteractable.conversationActive)
        {
            inCharacterView = true;
            inSceneView = false;
        }
        else
        {
            inCharacterView = false;
            inSceneView = true;

        }
    }


}

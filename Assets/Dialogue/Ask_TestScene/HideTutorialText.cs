using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTutorialText : MonoBehaviour
{

    public GameObject[] text;
    public GameObject tutorialButton;

    private void Update()
    {
        if(SceneSwitch.inCharacterView)
        {
            tutorialButton.SetActive(false);
            for (int i = 0; i < text.Length; i++)
            {
                text[i].gameObject.SetActive(false);
            }
        }

        if (SceneSwitch.inSceneView)
        {
            tutorialButton.SetActive(true);
        }
    }

    public void EnableHints()
    {
        for (int i = 0; i < text.Length; i++)
        {
            text[i].gameObject.SetActive(true);
        }
    }

}

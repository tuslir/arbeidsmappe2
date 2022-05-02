using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterPortraitScript : MonoBehaviour
{
    public Image image;

    public Button[] tokens;


    private void Start()
    {
    }

    public void ShowPerson(soPerson person)
    {
        image.sprite = person.Image;
    }

    private void Update()
    {
        if (SceneSwitch.inCharacterView)
        {
            for (int i = 0; i < tokens.Length; i++)
            {
                tokens[i].interactable = false;
            }
        }
        else if (SceneSwitch.inSceneView)
        {
            for (int i = 0; i < tokens.Length; i++)
            {
                tokens[i].interactable = true;
            }
        }


    }
}

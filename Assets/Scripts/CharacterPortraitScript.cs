using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterPortraitScript : MonoBehaviour
{
    public Image image;

    public Button[] tokens;
    public SpriteRenderer[] sceneSprites;
    public BoxCollider2D[] boxCollide;

    SceneSwitch sceneSwitch;


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
                sceneSprites[i].enabled = false;
                boxCollide[i].enabled = false;
            }
        }
        else if (SceneSwitch.inSceneView)
        {
            for (int i = 0; i < tokens.Length; i++)
            {
                tokens[i].interactable = true;
                sceneSprites[i].enabled = true;
                boxCollide[i].enabled = true;
            }
        }



    }
}

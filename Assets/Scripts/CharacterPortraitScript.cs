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

    public GameObject tokenCover;


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

            tokenCover.SetActive(true);

            for (int i = 0; i < tokens.Length; i++)
            {
                tokens[i].interactable = false;
                sceneSprites[i].enabled = false;
                boxCollide[i].enabled = false;
            }
        }
        else if (SceneSwitch.inSceneView)
        {

            tokenCover.SetActive(false);

                for (int i = 0; i < tokens.Length; i++)
                {
                    sceneSprites[i].enabled = true;
                    boxCollide[i].enabled = true;
                if (tokens[i].CompareTag("UnlockedToken"))
                {
                    tokens[i].interactable = true;

                }

            }

        }



    }
}

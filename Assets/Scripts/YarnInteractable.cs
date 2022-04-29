using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;

public class YarnInteractable : MonoBehaviour
{
    private DialogueRunner dialogueRunner;
    public string conversationStartNode;

    public soPerson person1;

    GameObject sceneSprites;
    public bool conversationActive;

    public Image image;

    public void Start()
    {
        sceneSprites = GameObject.FindGameObjectWithTag("SceneSprites");
        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
    }

    //run dialogue from {conversationStartNode}
    private void StartConversation()
    {
        dialogueRunner.StartDialogue(conversationStartNode);
        ShowPerson(person1);
    }
    public void ShowPerson(soPerson person)
    {
        image.sprite = person.Image;
    }

    public void OnMouseDown()
    {
        StartConversation();
        conversationActive = true;
    }

    private void Update()
    {
        if (conversationActive)
        {
 
            sceneSprites.SetActive(false);
        }
    }



}

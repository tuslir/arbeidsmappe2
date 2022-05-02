using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;

public class YarnInteractable : MonoBehaviour
{

    //this script makes object interactable with an OnMouseDown method.
    //the script calls on and runs StartDialogue through Yarn Spinner's DialogueRunner,
    //starting with the node assigned in Inspector.

    private DialogueRunner dialogueRunner;
    private LineView lineView;

    public string conversationStartNode;

    public static bool conversationActive;

    public Image image;
    public soPerson characterSpeaking;
    public soPerson hidePortrait;


    GameObject sceneSprites, characterView;


    public void Start()
    {
        sceneSprites = GameObject.FindGameObjectWithTag("SceneSprites");
        characterView = GameObject.FindGameObjectWithTag("CharacterPortrait");

        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
        lineView = FindObjectOfType<Yarn.Unity.LineView>();
        dialogueRunner.onDialogueComplete.AddListener(EndConversation);
    }

    //run dialogue from {conversationStartNode}
    private void StartConversation()
    {

        dialogueRunner.StartDialogue(conversationStartNode);
        ShowPerson(characterSpeaking);
        sceneSprites.SetActive(false);

    }

    public void ShowPerson(soPerson person)
    {
        characterView.SetActive(true);
        image.sprite = person.Image;
    }

    public void OnMouseDown()
    {
        StartConversation();
        conversationActive = true;
    }

    private void Update()
    {

        if (conversationActive && Input.GetKeyDown(KeyCode.Space)) lineView.OnContinueClicked();


    }

    public void EndConversation()
    {
        if (conversationActive) conversationActive = false;
        if (!conversationActive) sceneSprites.SetActive(true);

        ShowPerson(hidePortrait);
    }




}

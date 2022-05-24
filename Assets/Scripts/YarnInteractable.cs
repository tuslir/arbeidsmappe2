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
    private OptionsListView optionsList;


    public string conversationStartNode;

    public static bool conversationActive;

    public Image image;
    public soPerson characterSpeaking;
    public soPerson hidePortrait;

    public static bool isCurrentConversation;

    GameObject characterView;
   

    public void Start()
    {
        characterView = GameObject.FindGameObjectWithTag("CharacterPortrait");

        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
        dialogueRunner.onDialogueComplete.AddListener(EndConversation);

        lineView = FindObjectOfType<Yarn.Unity.LineView>();
    }

    //run dialogue from {conversationStartNode}
    public void StartConversation()
    {
        isCurrentConversation = true;

        dialogueRunner.StartDialogue(conversationStartNode);

        conversationActive = true;

        ShowPerson(characterSpeaking);
    }

    public void ShowPerson(soPerson person)
    {
        characterView.SetActive(true);
        image.sprite = person.Image;
    }

    public void OnMouseDown()
    {
        StartConversation();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            lineView.OnContinueClicked();
        }
        if (!conversationActive) ShowPerson(hidePortrait);
    }

    public void EndConversation()
    {

        if (isCurrentConversation) isCurrentConversation = false;

        if (conversationActive) conversationActive = false;

    }





}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnInteractable : MonoBehaviour
{
    private DialogueRunner dialogueRunner;
    public string conversationStartNode;

    public void Start()
    {
        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
    }

    //run dialogue from {conversationStartNode}
    private void StartConversation()
    {
        dialogueRunner.StartDialogue(conversationStartNode);
    }

    public void OnMouseDown()
    {
            StartConversation();
    }

}

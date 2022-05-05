using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Yarn.Unity;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{

    private void Start()
    {

    }


    public void EndConversation()
    {
        DialogueRunner dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
        OptionsListView optionsList = FindObjectOfType<Yarn.Unity.OptionsListView>();

        dialogueRunner.Stop();

        foreach (var dialogueView in dialogueRunner.dialogueViews)
        {
            if (dialogueView == null || dialogueView.isActiveAndEnabled == false) continue;

            dialogueView.DialogueComplete();
            dialogueView.DismissLine(() => { });

            optionsList.DialogueComplete();

        }

        if (YarnInteractable.isCurrentConversation) YarnInteractable.isCurrentConversation = false;

        if (YarnInteractable.conversationActive) YarnInteractable.conversationActive = false;

    }

}

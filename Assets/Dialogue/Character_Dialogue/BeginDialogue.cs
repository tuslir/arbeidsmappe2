using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;

public class BeginDialogue : MonoBehaviour
{

    DialogueRunner dialogueRunner;
    public string convoStart;

    YarnInteractable yarnInteractable;

    public GameObject askPortrait, sceneView;

    private void Awake()
    {
        yarnInteractable = FindObjectOfType<YarnInteractable>();
        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
    }

    private void Start()
    {
        StartCoroutine(Begin());
        dialogueRunner.onDialogueComplete.AddListener(EndConversation);


    }

    IEnumerator Begin()
    {
        yield return new WaitForSeconds(1f);
        dialogueRunner.StartDialogue(convoStart);
    }

    void EndConversation()
    {
        askPortrait.SetActive(false);
        sceneView.SetActive(true);
    }




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SpaceToYarn : MonoBehaviour
{
    LineView lineView;

    private void Start()
    {
        lineView = FindObjectOfType<Yarn.Unity.LineView>();

    }
    void Update()
    {
        if (YarnInteractable.conversationActive && Input.GetKeyDown(KeyCode.Space))
        {
            lineView.OnContinueClicked();
        }
    }
}

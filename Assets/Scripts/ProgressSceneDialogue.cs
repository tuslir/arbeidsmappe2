using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class ProgressSceneDialogue : MonoBehaviour
{

    [YarnCommand("intro_end")]
    public static void NextScene(bool introEnd = true)
    {
        if (introEnd)
        {
            SceneManager.LoadScene("IntroScene", LoadSceneMode.Single);
        }

    }

    [YarnCommand("ask_end")]
    public static void MainScene(bool conversationEnd = true)
    {
        if (conversationEnd)
        {
            SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
        }
    }


}

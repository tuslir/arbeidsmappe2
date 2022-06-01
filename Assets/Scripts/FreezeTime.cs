using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.SceneManagement;

public class FreezeTime : MonoBehaviour
{

    [YarnCommand("stop_time")]
    public static void WaitForText(bool pauseTime=true)
    {
        BoxCollider2D cover = GameObject.FindGameObjectWithTag("COVER").GetComponent<BoxCollider2D>();
        if (pauseTime) cover.enabled = true;
    }


    [YarnCommand("reset_time")]
    public static void ResetTime(bool pauseTime = false)
    {
        BoxCollider2D cover = GameObject.FindGameObjectWithTag("COVER").GetComponent<BoxCollider2D>();
        if (!pauseTime) cover.enabled = false;
    }

    [YarnCommand("show_unlocked")]
    public static void ShowUnlockedAnim(bool showUnlocked = true)
    {
        Animator _anim = GameObject.Find("ask_token").GetComponent<Animator>();

        if (showUnlocked)
        {
            _anim.SetBool("show_unlocked", true);
        }
    }

    [YarnCommand("end_anim")]
    public static void EndUnlockedAnim(bool showUnlocked = false)
    {
        Animator _anim = GameObject.Find("ask_token").GetComponent<Animator>();

        if (!showUnlocked)
        {
            _anim.SetBool("show_unlocked", false);
        }
    }

    [YarnCommand("the_end")]
    public static void TheEndFadeOut(bool theEnd = true)
    {
        Animator anim = GameObject.FindGameObjectWithTag("FadeOut").GetComponent<Animator>();

        if (theEnd)
        {
            anim.SetBool("fade_out", true);
        }
    }

    [YarnCommand("fade_in")]
    public static void TheEndFadeIn(bool theEnd = true)
    {
        Animator anim = GameObject.FindGameObjectWithTag("FadeOut").GetComponent<Animator>();

        if (theEnd)
        {
            anim.SetBool("fade_out", false);
        }
    }

    [YarnCommand("main_menu")]
    public static void BackToMainMenu(bool theEnd = true)
    {
        if (theEnd)
        {
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }
    }

}

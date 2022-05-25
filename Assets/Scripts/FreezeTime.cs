using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

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
        Animator _anim = GameObject.FindGameObjectWithTag("UnlockedToken").GetComponent<Animator>();

        if (_anim.gameObject.GetComponent<Animator>() == null)
        {
            return;
        }
        else if (showUnlocked)
        {
            _anim.SetBool("show_unlocked", true);
        }
    }

    [YarnCommand("end_anim")]
    public static void EndUnlockedAnim(bool showUnlocked = false)
    {
        Animator _anim = GameObject.FindGameObjectWithTag("UnlockedToken").GetComponent<Animator>();
        
        if (_anim.gameObject.GetComponent<Animator>() == null)
        {
            return;
        }
        else if (!showUnlocked)
        {
            _anim.SetBool("show_unlocked", false);
        }
    }

}

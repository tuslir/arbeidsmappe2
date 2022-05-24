using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;

public class UnlockTokenScript : MonoBehaviour
{


    [YarnCommand("unlock_ask")]
    public static void UnlockAsk(bool askToken=true)
    {
        Button askButton = GameObject.FindGameObjectWithTag("AskToken").GetComponent<Button>();


        if (askToken)
        {

            print("ask unlocked!");
            askButton.interactable = true;
            askButton.gameObject.transform.gameObject.tag = "UnlockedToken";
        }

    }

    [YarnCommand("unlock_jacob")]
    public static void UnlockJacob(bool jacobToken = true)
    {
        Button jacobButton = GameObject.FindGameObjectWithTag("JacobToken").GetComponent<Button>();


        if (jacobToken)
        {

            print("ask unlocked!");
            jacobButton.interactable = true;
            jacobButton.gameObject.transform.gameObject.tag = "UnlockedToken";

        }

    }

    [YarnCommand("unlock_lisa")]
    public static void UnlockLisa(bool lisaToken = true)
    {
        Button lisaButton = GameObject.FindGameObjectWithTag("LisaToken").GetComponent<Button>();


        if (lisaToken)
        {

            print("ask unlocked!");
            lisaButton.interactable = true;
            lisaButton.gameObject.transform.gameObject.tag = "UnlockedToken";

        }

    }


}

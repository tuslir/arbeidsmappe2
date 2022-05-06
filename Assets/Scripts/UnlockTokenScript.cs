using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class UnlockTokenScript : MonoBehaviour
{

    [YarnCommand("unlock_ask")]
    public static void UnlockAsk(bool askToken = true)
    {
        print("ask unlocked!");
    }

    [YarnCommand("unlock_jacob")]
    public static void UnlockJacob(bool jacobToken = true)
    {
        print("jacob unlocked!");
    }

    [YarnCommand("unlock_lisa")]
    public static void UnlockLisa(bool lisaToken = true)
    {
        print("lisa unlocked!");
    }


}

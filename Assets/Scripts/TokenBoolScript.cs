using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class TokenBoolScript : MonoBehaviour
{
    //public static TokenBoolScript Instance;

    public static Character currentCharacter;

    private void Start()
    {
        //if (Instance == null)
        //{
        //    Instance = this;
        //}
        //else Destroy(this);

    }

    public enum Character
    {
        Default,
        Jacob,
        Ask,
        Lisa
    }

    public void ChangeToDefault()
    {
        currentCharacter = Character.Default;
    }
    
    public void ChangeToJacob()
    {
        currentCharacter = Character.Jacob;
    }

    public void ChangeToAsk()
    {
        currentCharacter = Character.Ask;
    }

    public void ChangeToLisa()
    {
        currentCharacter = Character.Lisa;
    }

    void Update()
    {

        switch (currentCharacter)
        {
            case Character.Default:
                break;


            case Character.Jacob:

                break;


            case Character.Ask:
                break;


            case Character.Lisa:
                break;
        }

    }


    [YarnFunction("IsDefault")]

    public static bool IsDefault()
    {
        if (currentCharacter == Character.Default)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    [YarnFunction("IsJacob")]

    public static bool IsJacob()
    {
        if (currentCharacter==Character.Jacob)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    [YarnFunction("IsAsk")]

    public static bool IsAsk()
    {
        if (currentCharacter == Character.Ask)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    [YarnFunction("IsLisa")]

    public static bool IsLisa()
    {
        if (currentCharacter == Character.Lisa)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

}

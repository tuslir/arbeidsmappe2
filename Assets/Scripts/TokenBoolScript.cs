using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class TokenBoolScript : MonoBehaviour
{
    public static TokenBoolScript Instance;

    public Character currentCharacter;

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else Destroy(this);

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

}

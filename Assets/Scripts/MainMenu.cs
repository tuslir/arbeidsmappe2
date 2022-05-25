using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void StartGame()
    {
        StartCoroutine(WaitThenStart());
    }

    public void QuitGame()
    {
        StartCoroutine(WaitThenQuit());
    }

    IEnumerator WaitThenStart()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("EnterParty", LoadSceneMode.Single);

    }    
    
    IEnumerator WaitThenQuit()
    {
        yield return new WaitForSeconds(0.3f);
        Application.Quit();


    }

}

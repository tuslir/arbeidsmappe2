using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TokenScript : MonoBehaviour
{
    public Image image;

    public void ShowPerson(soPerson person) {
        image.sprite = person.Image;
    }
}

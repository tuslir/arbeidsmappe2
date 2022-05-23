using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOnHover : MonoBehaviour
{

    public Animator anim;

    private void OnMouseEnter()
    {
        anim.SetBool("hover", true);
    }

    private void OnMouseExit()
    {
        anim.SetBool("hover", false);
    }


}

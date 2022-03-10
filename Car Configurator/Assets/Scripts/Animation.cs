using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Animation : MonoBehaviour
{
    public Animator animator;


    public void OverEnter()
    {
        animator.Play("ShowIcon");
    }

    public void OverExit()
    {
        animator.Play("ShowIconBack");
    }
}

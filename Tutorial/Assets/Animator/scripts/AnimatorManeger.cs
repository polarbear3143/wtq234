using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManeger : MonoBehaviour
{
    public Animator animator;

    public void Die()
    {
        animator.SetTrigger("Death");

    }
}


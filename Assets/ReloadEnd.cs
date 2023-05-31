using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadEnd : StateMachineBehaviour
{
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        FindAnyObjectByType<ShootScript>().ReloadEnd();
    }
}
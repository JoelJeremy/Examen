using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadEnd : StateMachineBehaviour
{
    //This ends the reload animation after it has been excecuted when reloadeing untill full ammo.
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        FindAnyObjectByType<ShootScript>().ReloadEnd();
    }
}
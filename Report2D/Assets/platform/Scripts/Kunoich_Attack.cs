using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kunoich_Attack : StateMachineBehaviour
{
    private bool isNextAttack = false;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(isNextAttack){
            animator.Play("AM_Attack_2");
            isNextAttack = false;
        }
        else
            isNextAttack = true;
    }
}

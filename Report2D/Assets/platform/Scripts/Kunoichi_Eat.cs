using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kunoichi_Eat : StateMachineBehaviour
{
    public int target_Count = 2;
    private int current_Count = 0;

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){
        if(current_Count < target_Count - 1){
            current_Count++;
            animator.Play("AM_Eating");
        }
        else{
            animator.StopPlayback();
            current_Count = 0;
        }
    }
}

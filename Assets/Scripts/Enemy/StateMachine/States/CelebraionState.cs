using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class CelebraionState : State
{
   
    private HashAnimationNames _animationNames = new HashAnimationNames();
    private Animator _animator;

    private void Awake()
    {
       _animator = GetComponent<Animator>(); 
    }
    
    private void OnEnable   ()
    {
        _animator.Play(_animationNames.CelebrateHash);
    }

    private void OnDisable()
    {
        _animator.StopPlayback();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimation : MonoBehaviour
{
    [SerializeField] private string _triggerName;

    private Animator _animator;

    public bool _isPlayingAnimation = false;

    private void Start() 
    {
        _animator = GetComponent<Animator>();
    }    

    public void PlayAnimation()
    {
        if(!_isPlayingAnimation)
        {
            _animator.SetTrigger(_triggerName);

            _isPlayingAnimation = true;
        }
    }

    public void StoppedPlayingAnimation()
    {
        _isPlayingAnimation = false;
    }
}

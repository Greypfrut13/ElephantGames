using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpriteClickHandler : MonoBehaviour
{
    [SerializeField] private UnityEvent _onClick;

    private void OnMouseDown() 
    {
        _onClick?.Invoke();
    }
}

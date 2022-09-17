using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputErrorHandler : MonoBehaviour
{
    private PlayerInput Input;
   
    private void Start()
    {
        Input = GetComponent<PlayerInput>();
    }
 
    private void OnDisable()
    {
        Input.actions = null;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class InputManager : MonoBehaviour 
{
 
    public Vector2 CurrentInput
    {
        get
       {
           return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
       }
    }
}
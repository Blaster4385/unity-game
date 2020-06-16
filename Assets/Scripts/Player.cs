using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Player : MonoBehaviour 
 
{
 
    InputManager inputManager;
 
    [SerializeField] float playerSpeed = 5f;
 
    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
    }
 
    void Update ()
    {
        transform.Translate(inputManager.CurrentInput * Time.deltaTime * playerSpeed);
    }
}
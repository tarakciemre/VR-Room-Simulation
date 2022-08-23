using System.Collections;
using System.Collections.Generic;
using Lightbug.CharacterControllerPro.Core;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using XRController = UnityEngine.InputSystem.XR.XRController;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterActor _characterActor;
    
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _characterActor.Velocity = new Vector3(3, 0, 0);
    }
}

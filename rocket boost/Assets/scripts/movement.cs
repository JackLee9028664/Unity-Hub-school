using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    [SerializeField] InputAction thrust;
    [SerializeField] InputAction rotation;
    [SerializeField] float thrustStrength = 100f;
    [SerializeField] float rotationStrength = 100f;

   Rigidbody rb;
   AudioSource audioSource;

   private void Start() 
   {
    rb = GetComponent<Rigidbody>();
    audioSource = GetComponent<AudioSource>();
   }

    private void OnEnable() 
    {
        thrust.Enable();
        rotation.Enable();
    }


    private void FixedUpdate()
     {
       ProcessThrust();
       ProcessRotation();
    } 


   private void ProcessThrust()
    {
        if(thrust.IsPressed())
        {
           rb.AddRelativeForce(Vector3.up * thrustStrength * Time.fixedDeltaTime);
         
        }
    }


    private void ProcessRotation()
    {
     float rotationInput =  rotation.ReadValue<float>();
    if(rotationInput < 0)
    {
      applyRotation(rotationStrength); 
    }

    else if(rotationInput > 0)
    {
       applyRotation(-rotationStrength);
    }
    }

    private void applyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.fixedDeltaTime);
        rb.freezeRotation = false;
    }
}

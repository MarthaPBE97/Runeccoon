using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Script : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    private float speed = 1f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public Animator anim;

    void Start()
    {
       anim = gameObject.GetComponentInChildren<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        
        if( direction.magnitude >= 0.1f)
        {
            /*if(Input.GetKey("D")){
                speed =* 2f;
                anim.SetBool("isRunning", true);
            }
            else{
                speed = 1f;
                anim.SetBool("isRunning", false);
            } */

            float targetAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime );
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);

            anim.SetBool("isWalking",true);

        }
        else {
            anim.SetBool("isWalking",false);
        }
        
    }
}

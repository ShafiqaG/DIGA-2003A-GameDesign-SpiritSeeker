using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading;
using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.InputSystem;//calss/references unity's input system

public class Lurakamovement : MonoBehaviour

   

{
    public static Lurakamovement instance;
    private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator animator; //references the animator for the character's animation
    public ParticleSystem dust;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
    
        rb.linearVelocity = moveInput * moveSpeed; //we initially used "rb.velocity" but unity suggested we change it to "rb.linearVelocity" because "rb.velocity was obsolete
    }

    public void Move(InputAction.CallbackContext context) //movement references unity's input system which automatically reads "WASD" and arrow movement
    {
      animator.SetBool("isWalking", true);

      if (context.canceled)
      {
      
          animator.SetBool("isWalking", false);
          animator.SetFloat("LastInputX", moveInput.x);
          animator.SetFloat("LastInputY", moveInput.y);

            //Title:Player Movement with Unity Input System -Top Down Unity 2D #1
            //Author: YouTube- Game Code Library
            //Date: 16 May 2025
            //Code Version: 6000.0.49f1 (LTS)
            //Availibility: https://www.youtube.com/watch?v=DQY62meLVCk


            //Title: Week 9 - Lists _ Dictionaries _ Animations.pdf
            //Author: Andrea Hayes
            //Date: 22 May 2025
            //Code Version: n/a
            //Availibility: https://ulwazi.wits.ac.za/courses/81381/files/8743053?module_item_id=917473
        }

        moveInput = context.ReadValue<Vector2>();
      animator.SetFloat("InputX", moveInput.x);
      animator.SetFloat("InputY", moveInput.y);
    }

    public IEnumerator Knockback(float knockbackDuration, float knockbackPower, Transform obj) //creates a coroutine used to push the player away for a set amount of time
    {
        float timer = 0; //starts a timer
        while (knockbackDuration > timer) //applies a force as long as the duration isn't over
        {
            timer += Time.deltaTime;
            Vector2 direction = (obj.transform.position - this.transform.position).normalized;
            rb.AddForce(-direction * knockbackPower); //moves the player in direction with force

            //Title: Knockback TopDown -Unity 2D Tutorial
            //Author: YouTube- PekkeDev
            //Date: 04 May 2025
            //Code Version: 6000.0.49f1 (LTS)
            //Availibility: https://www.youtube.com/watch?v=ahadN8aGvXg

        }

        yield return 0;
    }
    

}

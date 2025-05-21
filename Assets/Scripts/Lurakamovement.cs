using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading;
using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.InputSystem;

public class Lurakamovement : MonoBehaviour

{
    public static Lurakamovement instance;
    private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator animator;

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
        rb.linearVelocity = moveInput * moveSpeed;
    }

    public void Move(InputAction.CallbackContext context)
    {
      animator.SetBool("isWalking", true);

      if (context.canceled)
      {
          animator.SetBool("isWalking", false);
          animator.SetFloat("LastInputX", moveInput.x);
          animator.SetFloat("LastInputY", moveInput.y);
      }

      moveInput = context.ReadValue<Vector2>();
      animator.SetFloat("InputX", moveInput.x);
      animator.SetFloat("InputY", moveInput.y);
    }

    public IEnumerator Knockback(float knockbackDuration, float knockbackPower, Transform obj)
    {
        float timer = 0;
        while (knockbackDuration > timer)
        {
            timer += Time.deltaTime;
            Vector2 direction = (obj.transform.position - this.transform.position).normalized;
            rb.AddForce(-direction * knockbackPower);
        }

        yield return 0;
    }
    
}

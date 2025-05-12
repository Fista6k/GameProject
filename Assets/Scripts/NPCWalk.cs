using System.IO;
using UnityEditor.Tilemaps;
using UnityEngine;

public class NPCWalk : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Transform leftLimit;
    public Transform rightLimit;

    int direction = 1;
    Animator animator;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        transform.Translate(Vector2.right * direction * moveSpeed * Time.deltaTime);

        animator.SetFloat("moveSpeed", Mathf.Abs(moveSpeed * direction));

        if (transform.position.x >= rightLimit.position.x && direction == 1)
        {
            Flip();
        }
        else if (transform.position.x <= leftLimit.position.x && direction == -1)
        {
            Flip();
        }
    }

    void Flip()
    {
        direction *= -1;
        
        if (spriteRenderer != null)
        {
            spriteRenderer.flipX = direction == -1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float velocidad = 5f;
    public int fuerza = 20;
    public float salto = 8f;
    private bool isJumping = false;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    public float velocidadCinta = -5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent < SpriteRenderer>();
    }

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");

        Vector2 movimiento = new Vector2(movimientoHorizontal, 0);

        rb.velocity = new Vector2(movimiento.x * velocidad, rb.velocity.y);

        // Girar el sprite en función de la dirección
        if (movimientoHorizontal < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (movimientoHorizontal > 0)
        {
            spriteRenderer.flipX = false;
        }

        // Salto
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(Vector2.up * salto, ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("suelo") || collision.gameObject.CompareTag("zombie") || collision.gameObject.CompareTag("cinta"))
        {
            isJumping = false;
        }
        if (collision.gameObject.CompareTag("Elevator"))
        {
            // Hacer al jugador hijo de la plataforma
            this.transform.parent = collision.transform;
            isJumping = false;
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("Box"))
        {
            //Lógica para los elementos que si colisionan.
            // Ignorar las colisiones entre el goblin y el objeto con el que ha colisionado
            Collider2D goblinCollider = GetComponent<Collider2D>();
            Collider2D otherCollider = collision.gameObject.GetComponent<Collider2D>();
            if (goblinCollider != null && otherCollider != null)
            {
                Physics2D.IgnoreCollision(goblinCollider, otherCollider, true);
            }


        }

        if (collision.gameObject.layer == LayerMask.NameToLayer("Invisible"))
        {
            // Hacer visible la plataforma
            SpriteRenderer spriteRenderer = collision.gameObject.GetComponent<SpriteRenderer>();
            if (spriteRenderer != null)
            {
                spriteRenderer.enabled = true; // Activa el SpriteRenderer
                //spriteRenderer.color = new Color(1, 1, 1, 1); // Ajustar color y opacidad
            }

          
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
       
        if (collision.gameObject.CompareTag("cinta"))
        {
            Debug.Log("Vamos para atras");
            // Aplicar un movimiento constante hacia la derecha
            //rb.velocity = new Vector2(velocidadCinta, rb.velocity.y);
            rb.AddForce(new Vector2(-velocidadCinta, 0), ForceMode2D.Force); 

        }
    }

   

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Elevator"))
        {
            // Desvincular al jugador de la plataforma
            this.transform.parent = null;
        }
        

    }

    

}

using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.AddForce((transform.up * jumpForce), ForceMode2D.Impulse);
        }
    }

   private void OnCollisionEnter2D(Collision2D other)
   {
        if(other.gameObject.CompareTag("PipePart"))
        {
            GameManager.instance.Lose();
            
        }
   }

}

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private float underGround = -0.34f;
    public float sideSpeed = 3f;
    public bool isGameOver = false;
    public bool isOnGround = true;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * sideSpeed * horizontalInput * Time.deltaTime);

        if(transform.position.y < underGround)
        {
            GameOver();
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isOnGround && collision.gameObject.CompareTag("enemy"))
        {
            GameOver();
        }
        
    }
    private void GameOver()
    {
        Debug.Log("Game Over");
        Destroy(gameObject);
        isGameOver = true;
    }
}

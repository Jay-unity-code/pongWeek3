using UnityEngine;
using UnityEngine.SceneManagement;

public class BallBehaviour : MonoBehaviour
{
   
    public float size = 1.0f;
    public float speed = 5f;
    public int score = 0;
    bool isPlaying = true;
    Vector3 direction;



    void Start()
    {
        direction = Vector3.right;

    }

    void Update()
    {
        if (isPlaying)
        {
            transform.localPosition += direction * speed * Time.deltaTime;
        }

          if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("GameScene");

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "Left_Bat":
                IncreaseScore();
                ChangeDirection(Vector3.right);
                break;
            case "Right_Bat":
                IncreaseScore();
                ChangeDirection(Vector3.left);
                break;
            case "Left_Goal":
                Debug.Log("Player 2 wins!!");
                isPlaying = false;
                break;
            case "Right_Goal":
                Debug.Log("Player 1 wins!!");
                isPlaying = false;
                break;
            default:
                Debug.Log("Collided with unknown object: " + collision);
                break;


        }

    }

    private void IncreaseScore()
    {
        score++;
        Debug.Log("Number of passes: " + score);
        speed += 0.5f;
    
    }

    private void ChangeDirection(Vector3 newDirection)
    {
        direction = newDirection;
    }

}


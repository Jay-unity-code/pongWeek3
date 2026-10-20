using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallBehaviour : MonoBehaviour
{
   
    public float size = 1.0f;
    public float speed = 5f;
    public BatBehaviour player1;
    public BatBehaviour player2;

 
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

     //     if (Input.GetKey(KeyCode.Space))
      //  {
      //      SceneManager.LoadScene("pongWeek3");

     //   }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "Left_Bat":
               
                ChangeDirection(Vector3.right);
                break;
            case "Right_Bat":
               
                ChangeDirection(Vector3.left);
                break;
            case "left goal":
                player2.IncreaseScore();
                isPlaying = false;
                break;
            case "right goal":
                player1.IncreaseScore();
                isPlaying = false;
                break;
            default:
                Debug.Log("Collided with unknown object: " + collision);
                break;


        }

    }


    private void ChangeDirection(Vector3 newDirection)
    {
        direction = newDirection;
    }

}


using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BatBehaviour : MonoBehaviour
{

    float speed = 5f;
    public int score = 0;
    public TextMeshProUGUI scoreText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if ((Input.GetKey(KeyCode.UpArrow) && gameObject.name == "Right_Bat")

            || (Input.GetKey(KeyCode.W) && gameObject.name == "Left_Bat"))


        {
            transform.localPosition += Vector3.up * speed * Time.deltaTime;
        }


        else if ((Input.GetKey(KeyCode.DownArrow) && gameObject.name ==
        "Right_Bat")

        || (Input.GetKey(KeyCode.S) && gameObject.name == "Left_Bat"))


        {
            transform.localPosition += Vector3.down * speed * Time.deltaTime;

        }

    }

    public void IncreaseScore()
    {



        score++;
        scoreText.text = gameObject.name == "Left_Bat" ? "Player 1 - " + score : "Player 2 - " + score;

        speed += 0.5f;

    }

    public int GetScore()
    { return score; }

}


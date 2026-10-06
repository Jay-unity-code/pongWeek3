using UnityEngine;

public class BatBehaviour : MonoBehaviour
{

    float speed = 5f;


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
}


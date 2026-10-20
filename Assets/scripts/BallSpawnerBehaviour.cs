using NUnit.Framework.Constraints;
using UnityEngine;

public class BallSpawnerBehaviour : MonoBehaviour
{

    public BallBehaviour ball;
    public BallBehaviour[] ballClones;



    public void Start()
    {
        ballClones = new BallBehaviour[5];
        SpawnBall();
    }


   public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SpawnBall();
        }
          else if (Input.GetKeyDown(KeyCode.Space))
         {
            for (int i = 0; i < ballClones.Length; i++)
            {
                if (ballClones[i] != null)
                    Destroy(ballClones[i].gameObject);
                ballClones[i] = null;
            }
            SpawnBall();
         }

    }

    public void SpawnBall()

    {
        for (int i = 0; i < ballClones.Length; i++)

        { 
            if (ballClones[i] == null)
            {
                ballClones[i] = Instantiate(ball);
                ballClones[i].transform.position = transform.position;
                ballClones[i].gameObject.SetActive(true);
                return;
            }
        }
        Debug.Log("Array is full! No more balls.");

    }   


}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    private float xLimit = 8.35f;
    private float yLimit = 4.35f;

    public GameObject Ball;
    public int currentEnemies = 1;
    private int wave = 1;

   

    // Update is called once per frame
    void Update()
    {
        if (currentEnemies == 0) //If we get rid of all of the current enemies,more will appear
        {

            wave++;

            //More bals will appear if we don't stop them like this since we specify how many will appear.
            currentEnemies = wave;

            for (int i = 0; i < wave; i++)
            {
                Instantiate(Ball, RandomPos(), Ball.transform.rotation);
            }
        }
    }

    //The enemy appears around the camera without leaving it's confines
    private Vector3 RandomPos()
    {
        return new Vector3(Random.Range(-xLimit, xLimit), Random.Range(-yLimit, yLimit), 0);
    }
    
}


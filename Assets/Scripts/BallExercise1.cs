using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallExercise1 : MonoBehaviour
{
    //Time to get what we need from exercise 1
    private Exercise1 Exercise1Juice;

    // Start is called before the first frame update
    void Start()
    {
        Exercise1Juice = FindObjectOfType<Exercise1>();
    }

    //We get rid of the enemy
    private void OnMouseDown()
    {

        Exercise1Juice.currentEnemies--;
        Destroy(gameObject);
    }
}

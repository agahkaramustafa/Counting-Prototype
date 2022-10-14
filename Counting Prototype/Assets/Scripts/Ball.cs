using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    Rigidbody ballPrefabRB;

    // Start is called before the first frame update
    void Start()
    {
        BallInstantiater();
    }

    public void BallInstantiater()
    {
        // Instantiate the ball in random locations between certain dimensions.
        float randomY = Random.Range(6f, 16f);
        float randomZ = Random.Range(-20f, 20f);
        Vector3 ballPosition = new Vector3(0, randomY, randomZ);

        Instantiate(ballPrefab, ballPosition, Quaternion.identity);
    }

}

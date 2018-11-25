using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    [SerializeField] Paddle paddle1;
    [SerializeField] float initXvelocity = 2f;
    [SerializeField] float initYvelocity = 15f;

    Vector2 paddleToBallVector;
    bool hasStarted;

	// Use this for initialization
	void Start () {

        paddleToBallVector = transform.position - paddle1.transform.position;
        hasStarted = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!hasStarted) {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
    }

    private void LockBallToPaddle() {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }

    private void LaunchOnMouseClick() {
        if (Input.GetMouseButtonDown(0)) {

            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(initXvelocity, initYvelocity);
        }
    }
}

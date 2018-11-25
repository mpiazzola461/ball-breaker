using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;

    [SerializeField] float screenWidthConversion = 16f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float mouseXpos = Input.mousePosition.x / Screen.width * screenWidthConversion;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mouseXpos, minX, maxX);
        transform.position = paddlePos;
        //transform.position = new Vector2(Input.mousePosition.x / Screen.width * screenWidthConversion, transform.position.y);
	}
}

using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour {
    Rigidbody rb;
    private int points;
    public Text countText;
    public float speed;
    public Text winText;
    void Start()
    {
        rb = GetComponent<Rigidbody>();


        points = 0;
        SetCountText();
        winText.text = "";
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);


    }
    void OnTriggerEnter(Collider other)
    {   

        if (other.gameObject.CompareTag("Pick up"))
        {
            other.gameObject.SetActive(false);
            points++;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count :" + points.ToString();
        if (points>= 9)
        {
            winText.text = "You win!";
            ExitGame();

        }
    }

    void ExitGame()
    {
        Application.Quit();
    }


}

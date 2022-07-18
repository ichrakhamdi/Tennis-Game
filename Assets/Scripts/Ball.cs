using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Text PlayerScore;
    public Text BotScore;
    public Transform Player; // the target where we aim to land the ball
    private int PS;
    private int BS;

    Vector3 PlayerPos; // initial position of the aiming gameObject which is the center of the opposite court

    private void Start()
    {
        PlayerPos = Player.position; 
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.transform.CompareTag("Wall1")) // if the ball hits a wall
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero; // reset it's velocity to 0 so it doesn't move anymore
            transform.position = new Vector3(Player.position.x + 0.2f, 0.7f ,Player.position.z); // reset it's position 
            PS ++;
        }
        if (collision.transform.CompareTag("Wall2")) // if the ball hits a wall
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero; // reset it's velocity to 0 so it doesn't move anymore
            transform.position = new Vector3(8.4f, 1, 0); // reset it's position 
            BS ++;
        }

        if(BS == 5)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        PlayerScore.text = PS.ToString();
        BotScore.text = BS.ToString();
    }

}
